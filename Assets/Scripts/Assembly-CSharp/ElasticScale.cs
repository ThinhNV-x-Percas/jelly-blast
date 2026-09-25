using UnityEngine;

public class ElasticScale : MonoBehaviour
{
    public float scaleStiffness = 400f;
    public float scaleDamping = 15f;

    private float prevScale;
    private float scale;
    private float scaleVel;

    public float popScaleVel = 20f;
    public float scaleForce;
    public float targetScale = 1f;

    private void FixedUpdate()
    {
        prevScale = scale;
        scaleVel += Time.fixedDeltaTime * (scaleForce + (targetScale - scale) * scaleStiffness - scaleVel * scaleDamping);
        scale += scaleVel * Time.fixedDeltaTime;
    }

    private void Update()
    {
        float t = Mathf.Clamp01((Time.time - Time.fixedTime) / Time.fixedDeltaTime);
        transform.localScale = Vector3.one * Mathf.Max(0f, prevScale + (scale - prevScale) * t);
    }

    public void SetScale(float _scale)
    {
        prevScale = _scale;
        scale = _scale;
        transform.localScale = Vector3.one * scale;
    }

    public void Pop()
    {
        scaleVel = popScaleVel;
        FixedUpdate();
        Update();
    }
}
