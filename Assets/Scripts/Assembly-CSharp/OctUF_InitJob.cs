using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;

[BurstCompile(FloatPrecision.Low, FloatMode.Fast)]
internal struct OctUF_InitJob : IJobParallelFor
{
    public NativeArray<int> parent;

    public void Execute(int i)
    {
        parent[i] = i;
    }
}
