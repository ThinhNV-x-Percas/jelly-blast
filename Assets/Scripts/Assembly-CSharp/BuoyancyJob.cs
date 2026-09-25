using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

[BurstCompile]
public struct BuoyancyJob : IJobParallelFor
{
    [ReadOnly]
    public NativeArray<float> waterDensities;

    [ReadOnly]
    public NativeArray<bool> isWater;

    [ReadOnly]
    public NativeArray<int> fishIds;

    public NativeArray<float2> deltaVel;

    public float buoyancyStrength;
    public float dt;

    public void Execute(int i)
    {
        // Buoyancy only applies to non-water particles immersed in water.
        if (isWater[i])
        {
            return;
        }
        float upForce = waterDensities[i] * buoyancyStrength * dt;
        if (fishIds[i] != -1)
        {
            upForce /= 1.5f;
        }
        float2 current = deltaVel[i];
        deltaVel[i] = new float2(current.x, current.y + upForce);
    }
}
