using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

[BurstCompile]
public struct SplashDownJob : IJobParallelFor
{
    [ReadOnly]
    public NativeArray<float2> predicted;

    [ReadOnly]
    public NativeArray<bool> isWater;

    [ReadOnly]
    public NativeMultiHashMap<int, int> cellMap;

    public NativeArray<float2> deltaVel;

    public float splashDownStrength;
    public int capacity;
    public float dt;
    public float radius;

    public void Execute(int i)
    {
        if (!isWater[i])
        {
            return;
        }
        float2 pos = predicted[i];
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
                    if (neighbor == i || isWater[neighbor])
                    {
                        continue;
                    }
                    float2 offset = predicted[neighbor] - pos;
                    float dist = math.length(offset);
                    if (dist <= 0f || dist >= radius)
                    {
                        continue;
                    }
                    float q = 1f - dist / radius;
                    float2 dir = offset / dist;
                    impulse -= dir * (splashDownStrength * q * dt);
                }
                while (cellMap.TryGetNextValue(out neighbor, ref it));
            }
        }
        deltaVel[i] += impulse;
    }
}
