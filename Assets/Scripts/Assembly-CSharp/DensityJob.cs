using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

[BurstCompile]
public struct DensityJob : IJobParallelFor
{
    [ReadOnly]
    public NativeArray<float2> predicted;

    [ReadOnly]
    public NativeMultiHashMap<int, int> cellMap;

    public NativeArray<float2> densities;

    [ReadOnly]
    public NativeArray<bool> isWater;

    [ReadOnly]
    public NativeHashMap<ulong, byte> ignorePairs;

    [ReadOnly]
    public NativeArray<int> powerUpIds;

    public float mass;
    public int capacity;
    public float radius;

    public void Execute(int i)
    {
        float2 pos = predicted[i];
        int gridX = (int)Mathf.Floor(pos.x / radius);
        int gridY = (int)Mathf.Floor(pos.y / radius);
        float density = 0f;
        float nearDensity = 0f;
        // 2D spiky kernel normalisation. Without it Sum(mass*q^2) can only reach
        // targetDensity by crushing ~30 particles into one point; with it, rest
        // spacing lands on particleRadius, which is what targetDensity was tuned for.
        float scale2 = 6f / (Mathf.PI * radius * radius);
        float scale3 = 10f / (Mathf.PI * radius * radius * radius);
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
                    if (isWater[i] != isWater[neighbor])
                    {
                        continue;
                    }
                    float dist = math.distance(predicted[neighbor], pos);
                    float q = 1f - dist / radius;
                    if (q > 0f)
                    {
                        density += mass * q * q * scale2;
                        nearDensity += mass * q * q * q * scale3;
                    }
                }
                while (cellMap.TryGetNextValue(out neighbor, ref it));
            }
        }
        densities[i] = new float2(Mathf.Max(density, 1E-06f), Mathf.Max(nearDensity, 1E-06f));
    }
}
