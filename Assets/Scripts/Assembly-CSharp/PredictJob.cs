using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

[BurstCompile]
public struct PredictJob : IJobParallelFor
{
    public NativeArray<float2> positions;
    public NativeArray<float2> velocities;
    public NativeArray<float2> predicted;
    public NativeArray<float2> gravities;
    public NativeArray<bool> isStatic;

    public float dt;

    public void Execute(int i)
    {
        if (isStatic[i])
        {
            velocities[i] = float2.zero;
            predicted[i] = positions[i];
            return;
        }
        float2 velocity = velocities[i] + gravities[i] * dt;
        velocities[i] = velocity;
        predicted[i] = positions[i] + velocity * dt;
    }
}
