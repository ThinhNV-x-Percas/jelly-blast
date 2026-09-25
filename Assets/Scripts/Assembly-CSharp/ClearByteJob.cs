using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;

[BurstCompile]
internal struct ClearByteJob : IJobParallelFor
{
    public NativeArray<byte> array;

    public void Execute(int i)
    {
        array[i] = 0;
    }
}
