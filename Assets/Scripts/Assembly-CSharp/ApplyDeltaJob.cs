using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

[BurstCompile]
public struct ApplyDeltaJob : IJobParallelFor
{
    public NativeArray<float2> velocities;

    [ReadOnly]
    public NativeArray<float2> deltaVel;

    public NativeArray<bool> isStatic;

    public void Execute(int i)
    {
        if (!isStatic[i])
        {
            velocities[i] += deltaVel[i];
        }
    }
}
