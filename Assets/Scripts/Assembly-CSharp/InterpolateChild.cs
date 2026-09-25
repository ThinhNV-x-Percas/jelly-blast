using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class InterpolateChild : MonoBehaviour
{
    [Tooltip("The Rigidbody2D whose motion we sample.")]
    public Rigidbody2D targetRigidbody;

    [Tooltip("The visual Transform (sprite/mesh) to detach and move.")]
    public Transform visual;

    private Vector3 prevPos;
    private Vector3 currPos;
    private Quaternion prevRot;
    private Quaternion currRot;
    private float visualZ;
    private Block block;

    private void Start()
    {
        if (targetRigidbody == null)
        {
            targetRigidbody = GetComponent<Rigidbody2D>();
        }
        if (targetRigidbody == null || visual == null)
        {
            Debug.LogError(name + " is missing targetRigidbody or visual for InterpolateChild.", this);
            enabled = false;
            return;
        }

        visual.SetParent(null, true);
        block = GetComponent<Block>();

        Transform target = targetRigidbody.transform;
        prevPos = currPos = target.position;
        prevRot = currRot = target.rotation;
        visualZ = visual.position.z;
    }

    private void FixedUpdate()
    {
        prevPos = currPos;
        prevRot = currRot;

        Transform target = targetRigidbody.transform;
        currPos = target.position;
        currRot = target.rotation;
    }

    private void LateUpdate()
    {
        float fixedDeltaTime = Time.fixedDeltaTime;
        float t = 1f;
        if (fixedDeltaTime > 0f)
        {
            t = Mathf.Clamp01((Time.time - Time.fixedTime) / fixedDeltaTime);
        }

        Quaternion rotation = Quaternion.Slerp(prevRot, currRot, t);
        if (block != null && block.isCleared)
        {
            return;
        }

        Vector3 position = Vector3.Lerp(prevPos, currPos, t);
        position.z = visualZ;
        visual.position = position;
        visual.rotation = rotation;
    }

    private void OnDestroy()
    {
        if (visual != null)
        {
            Destroy(visual.gameObject);
        }
    }
}
