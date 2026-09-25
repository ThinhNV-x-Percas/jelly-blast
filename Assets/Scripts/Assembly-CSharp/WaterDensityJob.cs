using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

[BurstCompile]
public struct WaterDensityJob : IJobParallelFor
{
    [ReadOnly]
    public NativeArray<float2> predicted;

    [ReadOnly]
    public NativeMultiHashMap<int, int> cellMap;

    [ReadOnly]
    public NativeArray<bool> isWater;

    public NativeArray<float> waterDensities;

    public float mass;
    public int capacity;
    public float radius;

    public void Execute(int i)
    {
        float2 pos = predicted[i];
        int gridX = (int)Mathf.Floor(pos.x / radius);
        int gridY = (int)Mathf.Floor(pos.y / radius);
        float density = 0f;
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
                    if (!isWater[neighbor])
                    {
                        continue;
                    }
                    float dist = math.distance(predicted[neighbor], pos);
                    float q = 1f - dist / radius;
                    if (q > 0f)
                    {
                        density += mass * q * q;
                    }
                }
                while (cellMap.TryGetNextValue(out neighbor, ref it));
            }
        }
        waterDensities[i] = density;
    }
}
