using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

// Union-find pass that links octopus particles of the same octopus lying within cellSize of
// each other, so OctUF_FlagHeadJob/OctUF_WriteRegionJob can tell which regions are still
// connected to a head particle.
[BurstCompile(FloatPrecision.Low, FloatMode.Fast)]
internal struct OctUF_UnionJob : IJob
{
    [ReadOnly]
    public NativeArray<float2> pos;

    [ReadOnly]
    public NativeArray<int> octopusIds;

    [ReadOnly]
    public NativeMultiHashMap<int, int> cellMap;

    [NativeDisableParallelForRestriction]
    public NativeArray<int> parent;

    public int capacity;
    public int count;

    // The native job read this from a static that the decompiler could not resolve. It is
    // both the grid cell size and the link distance; FluidSolver passes the same cell size
    // it gives FixedRadiusNeighborSearchJob so the cell keys line up with cellMap.
    public float cellSize;

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

    private static void Union(int a, int b, NativeArray<int> p)
    {
        int rootA = Find(a, p);
        int rootB = Find(b, p);
        if (rootA == rootB)
        {
            return;
        }

        if (rootA < rootB)
        {
            p[rootB] = rootA;
        }
        else
        {
            p[rootA] = rootB;
        }
    }

    public void Execute()
    {
        if (count <= 0 || capacity <= 0 || cellSize <= 0f)
        {
            return;
        }

        float maxDistanceSq = cellSize * cellSize;

        for (int i = 0; i < count; i++)
        {
            int octopusId = octopusIds[i];
            if (octopusId == -1)
            {
                continue;
            }

            float2 position = pos[i];
            int gridX = (int)math.floor(position.x / cellSize);
            int gridY = (int)math.floor(position.y / cellSize);

            for (int dy = -1; dy <= 1; dy++)
            {
                // Same cell key as FixedRadiusNeighborSearchJob, which fills cellMap.
                int hashY = (gridY + dy) * 0x3DCF;
                for (int dx = -1; dx <= 1; dx++)
                {
                    int key = (hashY + (gridX + dx) * 0x949475) % capacity;

                    if (!cellMap.TryGetFirstValue(key, out int other, out NativeMultiHashMapIterator<int> iterator))
                    {
                        continue;
                    }

                    do
                    {
                        if (other == i || octopusIds[other] != octopusId)
                        {
                            continue;
                        }

                        if (math.lengthsq(pos[other] - position) < maxDistanceSq)
                        {
                            Union(i, other, parent);
                        }
                    }
                    while (cellMap.TryGetNextValue(out other, ref iterator));
                }
            }
        }
    }
}
