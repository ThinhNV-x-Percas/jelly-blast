using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;

[BurstCompile(FloatPrecision.Low, FloatMode.Fast)]
internal struct OctUF_FlagHeadJob : IJobParallelFor
{
    // Path compression writes from several threads are benign: every writer stores
    // the same root, and no unions happen while this job runs.
    [NativeDisableParallelForRestriction]
    public NativeArray<int> parent;

    [ReadOnly]
    public NativeArray<byte> isHead;

    [NativeDisableParallelForRestriction]
    public NativeArray<byte> componentHasHead;

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
        if (isHead[i] == 0)
        {
            return;
        }
        componentHasHead[Find(i, parent)] = 1;
    }
}
