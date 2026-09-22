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

        // The native reconstruction tests (blobId + 1) against zero,
        // which is equivalent to skipping the sentinel value -1.
        if (blobId == -1)
        {
            return;
        }

        float2 midpoint = blobMidpoints[blobId];
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

        // Reconstructed from the native sequence:
        //   offset / distance
        //   * (distance - cohesionRadius)
        //   * springStrength
        //   * dt
        // added to deltaVel[index].
        float2 direction = offset / distance;
        float displacement = distance - cohesionRadius;
        float2 cohesionVelocity = direction * displacement * springStrength * dt;

        deltaVel[index] += cohesionVelocity;
    }
}
