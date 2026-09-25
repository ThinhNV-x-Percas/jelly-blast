using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

[BurstCompile]
public struct FixedRadiusNeighborSearchJob : IJobParallelFor
{
    [ReadOnly]
    public NativeArray<float2> positions;

    public float cellSize;
    public int capacity;

    public NativeMultiHashMap<int, int>.ParallelWriter cellMap;

    public void Execute(int index)
    {
        float2 position = positions[index];
        int gridX = (int)Mathf.Floor(position.x / cellSize);
        int gridY = (int)Mathf.Floor(position.y / cellSize);
        // Same hash as the query jobs; the remainder may be negative, which is fine as a key.
        int key = (gridY * 0x3DCF + gridX * 0x949475) % capacity;
        cellMap.Add(key, index);
    }
}
