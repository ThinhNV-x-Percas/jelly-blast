using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

[BurstCompile]
public struct OctopusHeadCohesionJob : IJobParallelFor
{
    [ReadOnly]
    public NativeArray<float2> positions;

    public NativeArray<float2> deltaVel;

    [ReadOnly]
    public NativeArray<int> octopusIds;

    [ReadOnly]
    public NativeArray<bool> inOctopusHead;

    [ReadOnly]
    public NativeHashMap<int, float2> octopusMidpoints;

    public float headCohesionRadius;
    public float headSpringStrength;
    public float dt;

    public void Execute(int index)
    {
        int blobId = octopusIds[index];
        if (blobId == -1 || !inOctopusHead[index])
        {
            return;
        }
        if (!octopusMidpoints.TryGetValue(blobId, out float2 midpoint))
        {
            return;
        }
        float2 offset = midpoint - positions[index];
        float distance = math.length(offset);
        if (distance == 0f)
        {
            return;
        }
        // The spring only engages once the particle drifts beyond the cohesion radius.
        if (distance <= headCohesionRadius)
        {
            return;
        }
        float2 direction = offset / distance;
        float displacement = distance - headCohesionRadius;
        deltaVel[index] += direction * displacement * headSpringStrength * dt;
    }
}
