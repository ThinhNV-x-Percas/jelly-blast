using TMPro;
using UnityEngine;

public class Lock : MonoBehaviour
{
    public GoalData goalData;

    private MaterialPropertyBlock _propBlock;

    public Transform collectionPoint;
    public Rigidbody2D pad;
    public ElasticScale counterElasticScale;
    public TextMeshPro counterText;
    public GameObject[] destroyObjects;
    public MeshRenderer[] colorMeshRenderers;

    private void Start()
    {
        goalData.displayedCount = goalData.count;
        UpdateCounterText();

        _propBlock = new MaterialPropertyBlock();
        foreach (MeshRenderer meshRenderer in colorMeshRenderers)
        {
            Color baseColor = Singleton<GameManager>.Instance.level.colors[goalData.fluidType];
            Color.RGBToHSV(baseColor, out float h, out float s, out float v);
            Color emissionColor = Color.HSVToRGB(h, s, v * 0.75f, true);

            ApplyColors(meshRenderer, 0, baseColor, emissionColor);
            ApplyColors(meshRenderer, 2, baseColor, emissionColor);
        }

        float direction = Random.Range(-1f, 1f) < 0f ? -1f : 1f;
        float magnitude = Random.Range(2f, 3f);
        pad.AddForce(Vector2.right * (direction * magnitude), ForceMode2D.Impulse);
    }

    private void ApplyColors(MeshRenderer meshRenderer, int materialIndex, Color baseColor, Color emissionColor)
    {
        meshRenderer.GetPropertyBlock(_propBlock, materialIndex);
        _propBlock.SetColor("_Color", baseColor);
        _propBlock.SetColor("_EmissionColor", emissionColor);
        meshRenderer.SetPropertyBlock(_propBlock, materialIndex);
    }

    public void RecieveParticle()
    {
        goalData.displayedCount--;
        UpdateCounterText();
        counterElasticScale.Pop();
        if (goalData.displayedCount == 0)
        {
            Open();
        }
    }

    public void UpdateCounterText()
    {
        counterText.text = goalData.displayedCount.ToString("D2");
    }

    public void Open()
    {
        Destroy(GetComponentInChildren<HingeJoint2D>());
        foreach (GameObject destroyObject in destroyObjects)
        {
            DestroyImmediate(destroyObject);
        }

        Singleton<GameManager>.Instance.coupler.RefreshBodies();
        Destroy(gameObject, 5f);
    }
}
