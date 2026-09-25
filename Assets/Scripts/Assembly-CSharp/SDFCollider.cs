using UnityEngine;

public class SDFCollider : MonoBehaviour
{
    public LayerMask collisionMask;

    public RenderTexture outputSDF;

    public int maxResolution = 512;

    public Vector2 sdfCenter;

    private SDFTextureGenerator generator;

    public float sourceValueThreshold = 0.5f;

    public SDFTextureGenerator.DownSampling downSampling;

    public SDFTextureGenerator.Precision precision = SDFTextureGenerator.Precision._32;

    public Shader whiteMaskShader;

    public void Init(FluidPhysicsCoupler coupler)
    {
        sdfCenter = Vector2.zero;
        Level level = Singleton<GameManager>.Instance.level;
        if (level != null)
        {
            level.GetColliderYExtents(out float minY, out float maxY);
            sdfCenter.y = (minY + maxY) * 0.5f;
        }

        float width = coupler.halfBounds.x * 2f;
        float height = coupler.halfBounds.y * 2f;
        float aspect = width / height;
        int texWidth;
        int texHeight;
        if (width < height)
        {
            texWidth = Mathf.RoundToInt(aspect * maxResolution);
            texHeight = maxResolution;
        }
        else
        {
            texWidth = maxResolution;
            texHeight = Mathf.RoundToInt(maxResolution / aspect);
        }

        if (outputSDF != null)
        {
            outputSDF.Release();
        }
        // FluidPhysicsCoupler.RegisterSDF reads this back into a NativeArray<float4>, so the
        // texture has to be 32-bit per channel - a half texture is read at half the stride
        // and every other value comes back as NaN.
        outputSDF = new RenderTexture(texWidth, texHeight, 0, RenderTextureFormat.ARGBFloat);
        outputSDF.name = "SDF_CaptureRT";
        outputSDF.filterMode = FilterMode.Point;
        outputSDF.wrapMode = TextureWrapMode.Clamp;
        outputSDF.useMipMap = false;
        outputSDF.autoGenerateMips = false;
        outputSDF.Create();

        GameObject cameraObject = new GameObject("SDF_CaptureCamera");
        Camera captureCamera = cameraObject.AddComponent<Camera>();
        captureCamera.transform.position = new Vector3(sdfCenter.x, sdfCenter.y, -10f);
        captureCamera.transform.rotation = Quaternion.identity;
        captureCamera.orthographic = true;
        captureCamera.orthographicSize = coupler.halfBounds.y;
        captureCamera.nearClipPlane = 0.01f;
        captureCamera.farClipPlane = 20f;
        captureCamera.clearFlags = CameraClearFlags.Color;
        captureCamera.backgroundColor = new Color(0f, 0f, 0f, 0f);
        captureCamera.cullingMask = collisionMask;
        captureCamera.targetTexture = outputSDF;
        captureCamera.depth = -100f;
        captureCamera.SetReplacementShader(whiteMaskShader, "");
        captureCamera.Render();
        captureCamera.targetTexture = null;
        DestroyImmediate(cameraObject);

        generator = new SDFTextureGenerator();
        generator.Update(outputSDF, sourceValueThreshold, downSampling, precision);
        outputSDF = generator.SdfTexture;
    }

    private void OnDisable()
    {
        if (generator != null)
        {
            generator.Release();
        }
    }
}
