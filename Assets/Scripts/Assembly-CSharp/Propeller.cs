using UnityEngine;

public class Propeller : MonoBehaviour
{
    private Rigidbody2D rb;

    public float angularVel = 100f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rb.angularVelocity = angularVel;
    }
}
