using UnityEngine;

public abstract class FluidRendererBase : MonoBehaviour
{
    public FluidCompute compute;
    public MeshRenderer mr;

    public Vector2[] interpPositions;
    public Vector2[] positions;

    [HideInInspector]
    public float[] scales;

    public int activeCount;
    public int maxParticles;

    [HideInInspector]
    public Vector2 min;

    [HideInInspector]
    public Vector2 max;

    public Vector2 position;

    internal float particleBoundsRadius = 0.4f;

    public virtual void Init()
    {
        if (maxParticles < 0)
        {
            maxParticles = 0;
        }

        positions = new Vector2[maxParticles];
        interpPositions = new Vector2[maxParticles];
        scales = new float[maxParticles];

        if (compute != null)
        {
            compute.OnPreUpdate += OnPreComputeUpdate;
        }
    }

    public virtual void OnPreComputeUpdate()
    {
        if (mr == null)
        {
            return;
        }

        Transform targetTransform = mr.transform;

        if (activeCount > 0)
        {
            int count = Mathf.Min(
                activeCount,
                Mathf.Min(interpPositions?.Length ?? 0, scales?.Length ?? 0));

            if (count <= 0)
            {
                position = Vector2.zero;
                Vector3 currentPosition1 = targetTransform.position;
                targetTransform.position = new Vector3(0f, 0f, currentPosition1.z);
                targetTransform.localScale = Vector3.zero;
                return;
            }

            float minX = float.PositiveInfinity;
            float minY = float.PositiveInfinity;
            float maxX = float.NegativeInfinity;
            float maxY = float.NegativeInfinity;

            for (int i = 0; i < count; i++)
            {
                float radius = particleBoundsRadius * scales[i];
                Vector2 p = interpPositions[i];

                minX = Mathf.Min(minX, p.x - radius);
                minY = Mathf.Min(minY, p.y - radius);
                maxX = Mathf.Max(maxX, p.x + radius);
                maxY = Mathf.Max(maxY, p.y + radius);
            }

            min = new Vector2(minX, minY);
            max = new Vector2(maxX, maxY);

            float centerX = (minX + maxX) * 0.5f;
            float centerY = (minY + maxY) * 0.5f;

            Vector3 currentPosition = targetTransform.position;
            targetTransform.position = new Vector3(
                centerX,
                centerY,
                currentPosition.z);

            Vector3 currentScale = targetTransform.localScale;
            targetTransform.localScale = new Vector3(
                maxX - minX,
                maxY - minY,
                currentScale.z);

            position = new Vector2(centerX, centerY);
            return;
        }

        position = Vector2.zero;

        Vector3 emptyPosition = targetTransform.position;
        targetTransform.position = new Vector3(
            0f,
            0f,
            emptyPosition.z);

        targetTransform.localScale = Vector3.zero;
    }

    protected virtual void OnDestroy()
    {
        if (compute != null)
        {
            compute.OnPreUpdate -= OnPreComputeUpdate;
        }
    }
}
