using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

[BurstCompile]
internal struct OctopusBodyCohesionJob : IJobParallelFor
{
    [ReadOnly]
    public NativeArray<float2> positions;

    public NativeArray<float2> deltaVel;

    [ReadOnly]
    public NativeArray<bool> regionHasHead;

    [ReadOnly]
    public NativeArray<int> octopusIds;

    [ReadOnly]
    public NativeHashMap<int, float2> octopusHeadMidpoints;

    public float bodyCohesionForce;
    public float dt;

    public void Execute(int index)
    {
        int blobId = octopusIds[index];
        // Regions still connected to a head are handled by OctopusHeadCohesionJob;
        // only headless regions are pulled back toward the head midpoint.
        if (blobId == -1 || regionHasHead[index])
        {
            return;
        }
        // An octopus whose head particles are all gone has no midpoint entry.
        if (!octopusHeadMidpoints.TryGetValue(blobId, out float2 midpoint))
        {
            return;
        }
        float2 offset = midpoint - positions[index];
        float distance = math.length(offset);
        if (distance <= 0f)
        {
            return;
        }
        float2 direction = offset / distance;
        deltaVel[index] += direction * (bodyCohesionForce * dt);
    }
}
