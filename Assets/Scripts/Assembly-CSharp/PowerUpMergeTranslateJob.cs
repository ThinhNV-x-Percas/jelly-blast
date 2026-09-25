using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

[BurstCompile]
public struct PowerUpMergeTranslateJob : IJobParallelFor
{
    public NativeArray<float2> positions;
    public NativeArray<float2> velocities;

    [ReadOnly]
    public NativeArray<int> powerUpIds;

    [ReadOnly]
    public NativeHashMap<int, float2> mergeDeltas;

    public float dt;

    public void Execute(int i)
    {
        int powerUpId = powerUpIds[i];
        if (powerUpId == -1 || !mergeDeltas.TryGetValue(powerUpId, out float2 delta))
        {
            return;
        }
        positions[i] += delta;
        velocities[i] = delta / dt;
    }
}
