using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

[BurstCompile]
public struct ClearDeltaJob : IJobParallelFor
{
    public NativeArray<float2> deltaVel;

    public void Execute(int index)
    {
        deltaVel[index] = float2.zero;
    }
}
