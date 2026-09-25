using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

[BurstCompile]
public struct BlobCohesionJob : IJobParallelFor
{
    [ReadOnly]
    public NativeArray<float2> positions;

    public NativeArray<float2> deltaVel;

    [ReadOnly]
    public NativeArray<int> blobIds;

    [ReadOnly]
    public NativeHashMap<int, float2> blobMidpoints;

    public float cohesionRadius;
    public float springStrength;
    public float dt;

    public void Execute(int index)
    {
        int blobId = blobIds[index];
        if (blobId == -1)
        {
            return;
        }

        if (!blobMidpoints.TryGetValue(blobId, out float2 midpoint))
        {
            return;
        }

        float2 offset = midpoint - positions[index];
        float distanceSq = math.lengthsq(offset);

        if (distanceSq <= 0f)
        {
            return;
        }

        float distance = math.sqrt(distanceSq);
        if (distance <= cohesionRadius)
        {
            return;
        }

        float2 direction = offset / distance;
        float displacement = distance - cohesionRadius;
        float2 cohesionVelocity = direction * displacement * springStrength * dt;

        deltaVel[index] += cohesionVelocity;
    }
}
