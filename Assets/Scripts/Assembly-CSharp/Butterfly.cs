using System;
using UnityEngine;

public class Butterfly : MonoBehaviour
{
    public float damping = 5f;
    public float collectForce = 100f;
    public float applyForceDuration = 0.5f;
    public float scaleUpDuration = 1f;

    private float startTime;
    private Vector2 startPos;
    private Vector2 pos;

    public Vector2 prevPos;
    public Vector2 vel;

    private Func<Vector2> getTargetPos;
    private Action onComplete;

    public void Init(Vector2 _position, Func<Vector2> _getTargetPos = null, Action _onComplete = null)
    {
        startTime = Time.time;
        pos = _position;
        startPos = pos;
        prevPos = pos;
        getTargetPos = _getTargetPos;
        onComplete = _onComplete;

        transform.GetChild(0).localScale = Vector3.one * 0.45f;

        ElasticScale elasticScale = GetComponent<ElasticScale>();
        elasticScale.SetScale(0f);
        elasticScale.Pop();
    }

    private void FixedUpdate()
    {
        prevPos = pos;

        Vector2 target = getTargetPos != null ? getTargetPos() : startPos;
        float t = Mathf.Clamp01((Time.time - startTime) / applyForceDuration);

        Vector2 delta = target - pos;
        float length = delta.magnitude;
        Vector2 dir = length > 1E-05f ? delta / length : Vector2.zero;

        vel += dir * collectForce * t * Time.fixedDeltaTime;
        vel -= vel * damping * Time.fixedDeltaTime;
        pos += vel * Time.fixedDeltaTime;

        // Finished once the butterfly has passed the target along the start->target direction.
        if (Vector2.Dot(pos - target, target - startPos) <= 0f)
            return;

        onComplete?.Invoke();
        Destroy(gameObject);
    }

    public void Complete()
    {
        onComplete?.Invoke();
        Destroy(gameObject);
    }

    private void Update()
    {
        if (Time.time < startTime)
        {
            transform.position = new Vector3(pos.x, pos.y, transform.position.z);
            transform.localScale = Vector3.zero;
            return;
        }

        float t = Mathf.Clamp01((Time.time - Time.fixedTime) / Time.fixedDeltaTime);
        Vector2 p = prevPos + (pos - prevPos) * t;
        transform.position = new Vector3(p.x, p.y, -6f);
    }
}
