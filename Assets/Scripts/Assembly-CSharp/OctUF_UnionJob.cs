[global::Unity.Burst.BurstCompile(global::Unity.Burst.FloatPrecision.Low, global::Unity.Burst.FloatMode.Fast)]
internal struct OctUF_UnionJob : global::Unity.Jobs.IJob
{
    [global::Unity.Collections.ReadOnly]
    public global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> pos;

    [global::Unity.Collections.ReadOnly]
    public global::Unity.Collections.NativeArray<int> octopusIds;

    [global::Unity.Collections.ReadOnly]
    public global::Unity.Collections.NativeMultiHashMap<int, int> cellMap;

    [global::Unity.Collections.NativeDisableParallelForRestriction]
    public global::Unity.Collections.NativeArray<int> parent;

    public int capacity;
    public int count;

    // The original IL2CPP job loaded this value from a decompiler-unresolved
    // static configuration object. Keep it as data so the job remains Burst-safe.
    // FluidSolver should pass particleRadius * 2f (the same cell size used by
    // FixedRadiusNeighborSearchJob) when constructing this job.
    public float cellSize;

    private const int CellHashXOffset = 1;
    private const int CellHashYMultiplier = 397;

    private static int Find(int x, global::Unity.Collections.NativeArray<int> p)
    {
        int root = x;

        // Find root.
        while (p[root] != root)
        {
            root = p[root];
        }

        // Path compression.
        while (p[x] != x)
        {
            int next = p[x];
            p[x] = root;
            x = next;
        }

        return root;
    }

    private static void Union(
        int a,
        int b,
        global::Unity.Collections.NativeArray<int> p)
    {
        int rootA = Find(a, p);
        int rootB = Find(b, p);

        if (rootA == rootB)
        {
            return;
        }

        // The native reconstruction compares root ids and attaches the
        // larger root to the smaller one. This keeps the representative
        // deterministic across the job.
        if (rootA < rootB)
        {
            p[rootB] = rootA;
        }
        else
        {
            p[rootA] = rootB;
        }
    }

    private static int PositiveModulo(int value, int modulus)
    {
        if (modulus <= 0)
        {
            return 0;
        }

        int result = value % modulus;
        return result < 0 ? result + modulus : result;
    }

    private static int HashCell(global::Unity.Mathematics.int2 cell, int capacity)
    {
        unchecked
        {
            // The original job reduces a deterministic integer cell hash
            // through capacity before querying NativeMultiHashMap.
            //
            // Vector2Int-style hashing is used here. The exact hash helper
            // body was one of the pieces lost by IL2CPP reconstruction.
            int hash = (cell.x * CellHashYMultiplier) ^ cell.y;
            return PositiveModulo(hash, capacity);
        }
    }

    private static void ScanCell(
        int key,
        int particleIndex,
        int octopusId,
        global::Unity.Collections.NativeMultiHashMap<int, int> cells,
        global::Unity.Collections.NativeArray<int> octopusIds,
        global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> positions,
        global::Unity.Collections.NativeArray<int> parents,
        float maxDistanceSq)
    {
        global::Unity.Collections.NativeMultiHashMapIterator<int> iterator;
        int otherIndex;

        if (!cells.TryGetFirstValue(key, out otherIndex, out iterator))
        {
            return;
        }

        do
        {
            if (otherIndex < 0 || otherIndex >= octopusIds.Length)
            {
                continue;
            }

            if (otherIndex == particleIndex)
            {
                continue;
            }

            if (octopusIds[otherIndex] != octopusId)
            {
                continue;
            }

            global::Unity.Mathematics.float2 delta =
                positions[otherIndex] - positions[particleIndex];

            float distanceSq = global::Unity.Mathematics.math.lengthsq(delta);
            if (distanceSq < maxDistanceSq)
            {
                Union(particleIndex, otherIndex, parents);
            }
        }
        while (cells.TryGetNextValue(out otherIndex, ref iterator));
    }

    public void Execute()
    {
        int particleCount = count;

        if (particleCount <= 0 ||
            capacity <= 0 ||
            !parent.IsCreated ||
            !pos.IsCreated ||
            !octopusIds.IsCreated ||
            !cellMap.IsCreated)
        {
            return;
        }

        particleCount = global::Unity.Mathematics.math.min(
            particleCount,
            parent.Length);

        particleCount = global::Unity.Mathematics.math.min(
            particleCount,
            pos.Length);

        particleCount = global::Unity.Mathematics.math.min(
            particleCount,
            octopusIds.Length);

        if (particleCount <= 0)
        {
            return;
        }

        // cellSize is unresolved in the original reconstruction. When the
        // caller does not provide it, avoid inventing a world-space unit and
        // fall back to a very small value. The normal FluidSolver call site
        // should pass particleRadius * 2f.
        float effectiveCellSize = cellSize;
        if (effectiveCellSize <= 0f)
        {
            return;
        }

        float maxDistanceSq = effectiveCellSize * effectiveCellSize;

        for (int i = 0; i < particleCount; i++)
        {
            int octopusId = octopusIds[i];

            // FluidSolver initializes inactive object ids to -1.
            if (octopusId < 0)
            {
                continue;
            }

            global::Unity.Mathematics.float2 position = pos[i];

            int cellX = (int)global::Unity.Mathematics.math.floor(
                position.x / effectiveCellSize);

            int cellY = (int)global::Unity.Mathematics.math.floor(
                position.y / effectiveCellSize);

            // The native job checks six cells: three cells across X and two
            // consecutive rows in Y. This is the usual half-neighbourhood
            // used to avoid processing every pair twice.
            for (int dy = 0; dy <= 1; dy++)
            {
                for (int dx = -1; dx <= 1; dx++)
                {
                    int key = HashCell(
                        new global::Unity.Mathematics.int2(
                            cellX + dx,
                            cellY + dy),
                        capacity);

                    ScanCell(
                        key,
                        i,
                        octopusId,
                        cellMap,
                        octopusIds,
                        pos,
                        parent,
                        maxDistanceSq);
                }
            }
        }
    }
}
