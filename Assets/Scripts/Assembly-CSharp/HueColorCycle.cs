using UnityEngine;

public class HueColorCycle : MonoBehaviour
{
    private Renderer _renderer;

    public Color baseColor;

    public float colorLerpSpeed = 2f;

    private Material _material;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
    }

    private void Update()
    {
        float hue = 1f - Mathf.Abs(Mathf.Repeat(Time.time * colorLerpSpeed, 2f) - 1f);
        HSBColor hsb = HSBColor.FromColor(baseColor);
        Color color = HSBColor.ToColor(new HSBColor(hue, hsb.s, hsb.b));
        color.a = baseColor.a;

        if (_material == null)
        {
            _material = _renderer.material;
        }
        _material.color = color;
    }

    private void OnDestroy()
    {
        // Renderer.material creates a per-object instance that Unity does not free with the object.
        if (_material != null)
        {
            Destroy(_material);
        }
    }
}
