using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

[BurstCompile]
public struct IntegrateJob : IJobParallelFor
{
    public NativeArray<float2> positions;
    public NativeArray<float2> velocities;
    public NativeArray<bool> isStatic;

    public float dt;

    public void Execute(int i)
    {
        if (!isStatic[i])
        {
            positions[i] += velocities[i] * dt;
        }
    }
}
