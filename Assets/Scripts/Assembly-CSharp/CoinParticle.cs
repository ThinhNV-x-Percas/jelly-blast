using UnityEngine;

public class CoinParticle : MonoBehaviour
{
    public RectTransform rt;
    public Vector2 acceleration;
    public Vector2 velocity;
    public Vector2 position;
    public Vector2 prevPosition;
    public float value;
    public float damping = 100f;
    public float rotation;
    public float angularVelocity;

    private float prevRotation;

    private void Awake()
    {
        rt = GetComponent<RectTransform>();
    }

    private void Start()
    {
        position = rt.anchoredPosition;
        prevPosition = position;
        prevRotation = rotation;
    }

    public void UpdatePhysics()
    {
        float deltaTime = Time.deltaTime;
        prevPosition = position;
        velocity += acceleration * deltaTime;
        velocity -= velocity * damping * deltaTime;
        acceleration = Vector2.zero;
        position += velocity * deltaTime;
        prevRotation = rotation;
        rotation += angularVelocity * deltaTime;
    }

    public void Update()
    {
        float t = Mathf.Clamp01((Time.time - Time.fixedTime) / Time.fixedDeltaTime);
        rt.anchoredPosition = Vector2.Lerp(prevPosition, position, t);
        rt.localEulerAngles = new Vector3(0f, 0f, Mathf.LerpAngle(prevRotation, rotation, t));
    }
}
