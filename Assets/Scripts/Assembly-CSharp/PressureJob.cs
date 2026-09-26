using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

[BurstCompile]
public struct PressureJob : IJobParallelFor
{
    [ReadOnly]
    public NativeArray<float2> predicted;

    [ReadOnly]
    public NativeArray<float2> densities;

    [ReadOnly]
    public NativeMultiHashMap<int, int> cellMap;

    [ReadOnly]
    public NativeArray<int> particleTypes;

    [ReadOnly]
    public NativeArray<bool> isHoneyCoated;

    [ReadOnly]
    public NativeHashMap<ulong, byte> ignorePairs;

    [ReadOnly]
    public NativeArray<int> powerUpIds;

    [ReadOnly]
    public NativeArray<bool> isWater;

    [ReadOnly]
    public NativeArray<int> clumpIds;

    [ReadOnly]
    public NativeArray<int> fishIds;

    [ReadOnly]
    public NativeArray<float> nearPressureMultipliers;

    public NativeArray<float2> deltaVel;

    public float interFluidRepelStr;
    public float honeyRepelStr;
    public float clumpRepelStrength;
    public float waterReactionGlobal;
    public float pressureMultiplier;
    public float targetDensity;
    public float dt;
    public int capacity;
    public float radius;

    public void Execute(int i)
    {
        float2 pos = predicted[i];
        float2 d = densities[i];
        float pressure = pressureMultiplier * (d.x - targetDensity);
        float nearPressure = nearPressureMultipliers[i] * d.y;
        int gridX = (int)Mathf.Floor(pos.x / radius);
        int gridY = (int)Mathf.Floor(pos.y / radius);
        float2 impulse = float2.zero;
        // Fixed-radius hash with cellSize == radius: the 3x3 ring, not a 2x2 corner.
        for (int dy = -1; dy <= 1; dy++)
        {
            int hashY = (gridY + dy) * 0x3DCF;
            for (int dx = -1; dx <= 1; dx++)
            {
                int key = (hashY + (gridX + dx) * 0x949475) % capacity;
                if (!cellMap.TryGetFirstValue(key, out int neighbor, out var it))
                {
                    continue;
                }
                do
                {
                    if (neighbor == i)
                    {
                        continue;
                    }
                    int myPowerUpId = powerUpIds[i];
                    int neighborPowerUpId = powerUpIds[neighbor];
                    if (myPowerUpId != -1 && neighborPowerUpId != -1)
                    {
                        ulong pairKey = ((ulong)(uint)myPowerUpId << 32) | (uint)neighborPowerUpId;
                        if (ignorePairs.ContainsKey(pairKey))
                        {
                            continue;
                        }
                    }
                    float2 offset = predicted[neighbor] - pos;
                    float dist = math.length(offset);
                    if (dist <= 0f || dist >= radius)
                    {
                        continue;
                    }
                    float q = 1f - dist / radius;
                    float2 dir = offset / dist;
                    // Water reacting to non-water is an extra push; in the native job this test falls
                    // through to the rules below, so water still collides with other fluids via the
                    // inter-fluid repulsion (making it exclusive let water pass through them).
                    if (isWater[i] != isWater[neighbor])
                    {
                        impulse -= dir * (waterReactionGlobal * q * dt * 0.5f);
                    }

                    // As in the native job, each fluid is its own SPH fluid: pressure only acts between
                    // particles of the same kind, and different kinds just push apart (first matching
                    // rule wins). Applying pressure across kinds made mud, snow, honey and the colours
                    // merge into one mass instead of staying separate blobs.
                    if (isHoneyCoated[i] != isHoneyCoated[neighbor])
                    {
                        impulse -= dir * (honeyRepelStr * q * dt);
                    }
                    else if (particleTypes[i] != particleTypes[neighbor])
                    {
                        impulse -= dir * (interFluidRepelStr * q * dt);
                    }
                    else if (clumpIds[i] != clumpIds[neighbor])
                    {
                        impulse -= dir * (clumpRepelStrength * q * dt);
                    }
                    else
                    {
                        float2 dn = densities[neighbor];
                        float neighborPressure = pressureMultiplier * (dn.x - targetDensity);
                        float neighborNearPressure = nearPressureMultipliers[neighbor] * dn.y;
                        float avgPressure = (pressure + neighborPressure) * 0.5f;
                        float avgNearPressure = (nearPressure + neighborNearPressure) * 0.5f;
                        float displacement = dt * (avgPressure * q + avgNearPressure * q * q);
                        impulse -= dir * (displacement * 0.5f);
                    }
                }
                while (cellMap.TryGetNextValue(out neighbor, ref it));
            }
        }
        deltaVel[i] += impulse;
    }
}
