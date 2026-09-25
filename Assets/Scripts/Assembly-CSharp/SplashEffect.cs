using UnityEngine;

public class SplashEffect : MonoBehaviour
{
    private MaterialPropertyBlock _propBlock;

    public MeshRenderer mr;

    private void Awake()
    {
        _propBlock = new MaterialPropertyBlock();
    }

    public void SetColor(Color color)
    {
        mr.GetPropertyBlock(_propBlock);
        // The literal was lost in the metadata dump; _Color is the colour property of the splash material.
        _propBlock.SetColor("_Color", color);
        mr.SetPropertyBlock(_propBlock);
    }
}
