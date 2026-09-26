using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

[BurstCompile]
public struct ViscosityJob : IJobParallelFor
{
    [ReadOnly]
    public NativeArray<float2> predicted;

    [ReadOnly]
    public NativeArray<float2> velocities;

    [ReadOnly]
    public NativeMultiHashMap<int, int> cellMap;

    [ReadOnly]
    public NativeArray<int> particleTypes;

    [ReadOnly]
    public NativeHashMap<ulong, byte> ignorePairs;

    [ReadOnly]
    public NativeArray<int> powerUpIds;

    [ReadOnly]
    public NativeArray<bool> isWater;

    public NativeArray<float2> deltaVel;

    [ReadOnly]
    public NativeArray<float> viscosityStrengths;

    public float dt;
    public int capacity;
    public float radius;
    public float waterReactionGlobal;

    [ReadOnly]
    public NativeArray<int> fishIds;

    public void Execute(int i)
    {
        float2 pos = predicted[i];
        float2 vel = velocities[i];
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
                    float closingSpeed = math.dot(vel - velocities[neighbor], dir);
                    if (closingSpeed <= 0f)
                    {
                        continue;
                    }
                    float strength = viscosityStrengths[i];
                    if (isWater[i] != isWater[neighbor])
                    {
                        strength *= waterReactionGlobal;
                    }
                    else if (particleTypes[i] != particleTypes[neighbor])
                    {
                        // Viscosity smooths velocities within one fluid; different fluids slide past
                        // each other (the native job carries particleTypes for this test).
                        continue;
                    }
                    impulse -= dir * (strength * q * closingSpeed * dt * 0.5f);
                }
                while (cellMap.TryGetNextValue(out neighbor, ref it));
            }
        }
        deltaVel[i] += impulse;
    }
}
