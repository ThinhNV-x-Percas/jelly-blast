using UnityEngine;

public class BlinkingEyes : MonoBehaviour
{
    private static readonly int BlinkAmountId = Shader.PropertyToID("_BlinkAmount");

    private float blinkStartTime;
    // The native constructor writes one duplicated value into both blinkDuration and blinkHold.
    private float blinkDuration = 0.2f;
    private float blinkHold = 0.2f;
    private float blinkPeriod = 5f;

    private MeshRenderer mr;
    private MaterialPropertyBlock _propBlock;

    private void Start()
    {
        blinkStartTime = Random.Range(0f, blinkPeriod);
        _propBlock = new MaterialPropertyBlock();
        mr = GetComponent<MeshRenderer>();
    }

    private static float EaseInOutCubic(float x)
    {
        return x < 0.5f ? 4f * x * x * x : 1f - Mathf.Pow(-2f * x + 2f, 3f) * 0.5f;
    }

    private void LateUpdate()
    {
        float total = blinkDuration + blinkHold;
        float t = (Time.time - blinkStartTime) % blinkPeriod / total;
        float value;
        if (t < 0.5f)
        {
            value = Mathf.Clamp01(1f - EaseInOutCubic(t * 2f));
        }
        else
        {
            float holdFraction = blinkHold / total;
            if (t < holdFraction + 0.5f)
            {
                value = 0f;
            }
            else if (t < holdFraction + 1f)
            {
                value = Mathf.Clamp01(EaseInOutCubic((t - 0.5f - holdFraction) * 2f));
            }
            else
            {
                value = 1f;
            }
        }

        mr.GetPropertyBlock(_propBlock);
        _propBlock.SetFloat(BlinkAmountId, value);
        mr.SetPropertyBlock(_propBlock);
    }
}
