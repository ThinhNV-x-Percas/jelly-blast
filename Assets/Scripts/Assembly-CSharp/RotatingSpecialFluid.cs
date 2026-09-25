using System.Collections.Generic;
using UnityEngine;

public class RotatingSpecialFluid : SpecialFluid
{
    public float zRotation;

    private readonly Dictionary<int, Vector2> prevOffset = new Dictionary<int, Vector2>();

    private float filteredDelta;

    public override void OnPreComputeUpdate()
    {
        base.OnPreComputeUpdate();

        float sumCurXPrevX = 0f;
        float sumCurYPrevX = 0f;
        float sumCurXPrevY = 0f;
        float sumCurYPrevY = 0f;

        foreach (int particleId in particleIds)
        {
            if (!solver.idToIndex.TryGetValue(particleId, out int slot))
                continue;

            Vector2 currentOffset = (Vector2)solver.positions[slot] - position;
            if (!prevOffset.TryGetValue(particleId, out Vector2 previousOffset))
                previousOffset = currentOffset;

            float distSq = currentOffset.x * currentOffset.x + currentOffset.y * currentOffset.y;
            sumCurXPrevX += currentOffset.x * distSq * previousOffset.x;
            sumCurYPrevX += currentOffset.y * distSq * previousOffset.x;
            sumCurXPrevY += currentOffset.x * distSq * previousOffset.y;
            sumCurYPrevY += currentOffset.y * distSq * previousOffset.y;

            prevOffset[particleId] = currentOffset;
        }

        float angleDelta = Mathf.Atan2(sumCurYPrevX - sumCurXPrevY, sumCurYPrevY + sumCurXPrevX);
        filteredDelta += (angleDelta - filteredDelta) * 0.85f;
        zRotation += filteredDelta;

        mr.GetPropertyBlock(_propBlock);
        _propBlock.SetVector("_Position", new Vector4(position.x, position.y, 0f, 0f));
        _propBlock.SetVector("_Rotation", new Vector4(Mathf.Sin(zRotation), zRotation, 0f, 0f));
        mr.SetPropertyBlock(_propBlock);
    }
}
