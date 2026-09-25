using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;

[BurstCompile(FloatPrecision.Low, FloatMode.Fast)]
internal struct OctUF_WriteRegionJob : IJobParallelFor
{
    [NativeDisableParallelForRestriction]
    public NativeArray<int> parent;

    [ReadOnly]
    public NativeArray<byte> componentHasHead;

    public NativeArray<bool> regionHasHead;

    private static int Find(int x, NativeArray<int> p)
    {
        int root = x;
        while (p[root] != root)
        {
            root = p[root];
        }
        while (p[x] != root)
        {
            int next = p[x];
            p[x] = root;
            x = next;
        }
        return root;
    }

    public void Execute(int i)
    {
        regionHasHead[i] = componentHasHead[Find(i, parent)] != 0;
    }
}
