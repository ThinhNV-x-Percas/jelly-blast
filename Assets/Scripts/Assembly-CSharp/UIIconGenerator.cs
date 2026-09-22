using System;
using UnityEngine;

public class UIIconGenerator : Singleton<UIIconGenerator>
{
    [Header("Render settings")]
    public int renderLayer;
    public Camera renderCamera;
    public int resolution;

    [Header("Prefabs & Materials")]
    public MeshRenderer quadPrefab;
    private MaterialPropertyBlock _propBlock;
    public Texture2D fluidTex;
    private Texture2DArray fluidTexArray;
    public Texture2D reflectionTex;
    public Material colorMaterial;

    [Header("Custom PNG Icons")]
    public Sprite fishIconSprite;

    private sealed class ColorIconPropertyBlockSetter
    {
        private readonly Color _color;

        public ColorIconPropertyBlockSetter(Color color)
        {
            _color = color;
        }

        public void Apply(MaterialPropertyBlock pb)
        {
            pb.SetColor("_Color", _color);
            pb.SetFloat("_Alpha", 0.3f);
        }
    }

    private void Awake()
    {
        _propBlock = new MaterialPropertyBlock();
        fluidTexArray = CreateArrayFromTexture(fluidTex);
    }

    public void UpdateIcons()
    {
        if (renderCamera == null)
            throw new NullReferenceException(nameof(renderCamera));

        renderCamera.enabled = true;

        RenderTexture temporary = RenderTexture.GetTemporary(
            resolution,
            resolution,
            0,
            RenderTextureFormat.Default);

        try
        {
            GameManager gameManager = Singleton<GameManager>.Instance;
            if (gameManager == null || gameManager.level == null || gameManager.level.goals == null)
                return;

            foreach (GoalData goal in gameManager.level.goals)
            {
                switch (goal.goalType)
                {
                    case GoalType.Fluid:
                        RenderColorIcon(
                            temporary,
                            gameManager.level.colors[goal.fluidType]);
                        break;

                    case GoalType.Ice:
                        RenderObjectIcon(
                            temporary,
                            gameManager.icePrefab != null ? gameManager.icePrefab.gameObject : null);
                        break;

                    case GoalType.Stone:
                        RenderObjectIcon(
                            temporary,
                            gameManager.stonePrefab != null ? gameManager.stonePrefab.gameObject : null);
                        break;

                    case GoalType.Mud:
                        RenderMudIcon(temporary);
                        break;

                    case GoalType.Snow:
                        RenderSnowIcon(temporary);
                        break;

                    case GoalType.Fish:
                        RenderObjectIcon(
                            temporary,
                            gameManager.fishPrefab != null ? gameManager.fishPrefab.gameObject : null);
                        break;

                    case GoalType.Octopus:
                        RenderObjectIcon(
                            temporary,
                            gameManager.octopusPrefab != null ? gameManager.octopusPrefab.gameObject : null);
                        break;

                    case GoalType.Butterfly:
                        RenderObjectIcon(
                            temporary,
                            gameManager.butterflyPrefab != null ? gameManager.butterflyPrefab.gameObject : null);
                        break;

                    case GoalType.Bee:
                        RenderObjectIcon(
                            temporary,
                            gameManager.beePrefab != null ? gameManager.beePrefab.gameObject : null);
                        break;
                }

                Texture2D texture = ConvertRenderTextureToTexture2D(temporary);
                if (texture == null)
                    throw new NullReferenceException(nameof(texture));

                Rect rect = new Rect(0f, 0f, texture.width, texture.height);
                Vector2 pivot = new Vector2(0.5f, 0.5f);

                goal.sprite = Sprite.Create(
                    texture,
                    rect,
                    pivot,
                    100f,
                    0u,
                    SpriteMeshType.FullRect);
            }
        }
        finally
        {
            RenderTexture.ReleaseTemporary(temporary);
            renderCamera.enabled = false;
        }
    }

    private void RenderColorIcon(RenderTexture targetRT, Color color)
    {
        ColorIconPropertyBlockSetter setter = new ColorIconPropertyBlockSetter(color);
        RenderFluidIcon(targetRT, colorMaterial, 0.3f, setter.Apply);
    }

    private void RenderMudIcon(RenderTexture targetRT)
    {
        GameManager gameManager = Singleton<GameManager>.Instance;
        if (gameManager == null)
            return;

        RenderFluidIcon(targetRT, gameManager.mudMaterial, 0.3f, null);
    }

    private void RenderSnowIcon(RenderTexture targetRT)
    {
        GameManager gameManager = Singleton<GameManager>.Instance;
        if (gameManager == null)
            return;

        RenderFluidIcon(targetRT, gameManager.snowMaterial, 0.3f, null);
    }

    private void RenderFluidIcon(
        RenderTexture targetRT,
        Material mat,
        float orthoScale = 0.3f,
        Action<MaterialPropertyBlock> pb = null)
    {
        if (quadPrefab == null || renderCamera == null)
            return;

        MeshRenderer meshRenderer = UnityEngine.Object.Instantiate(quadPrefab, transform);
        if (meshRenderer == null)
            return;

        Transform quadTransform = meshRenderer.transform;
        quadTransform.localPosition = Vector3.zero;
        quadTransform.localScale = new Vector3(
            orthoScale * 2f,
            orthoScale * 2f,
            1f);

        meshRenderer.material = mat;
        meshRenderer.GetPropertyBlock(_propBlock);

        GameManager gameManager = Singleton<GameManager>.Instance;
        if (gameManager != null && gameManager.light != null)
        {
            Vector3 forward = gameManager.light.transform.forward;
            _propBlock.SetVector(
                "_LightDirection",
                new Vector4(forward.x, forward.y, forward.z, 0f));
        }

        _propBlock.SetTexture("_FluidTexArray", fluidTexArray);
        _propBlock.SetTexture("_NoiseTex", SolidColor(Color.white));
        _propBlock.SetTexture("_ReflectionTex", reflectionTex);
        _propBlock.SetInt("_FluidType", 0);
        _propBlock.SetFloat("_Seed", -1f);

        pb?.Invoke(_propBlock);

        meshRenderer.SetPropertyBlock(_propBlock);

        GameObject gameObject = meshRenderer.gameObject;
        SetLayerRecursive(gameObject, renderLayer);

        renderCamera.orthographicSize = orthoScale;
        renderCamera.targetTexture = targetRT;
        renderCamera.Render();

        UnityEngine.Object.DestroyImmediate(gameObject);
    }

    private void RenderObjectIcon(
        RenderTexture targetRT,
        GameObject prefab,
        float orthoScale = 0.3f,
        Action<MaterialPropertyBlock> pb = null)
    {
        if (prefab == null || renderCamera == null)
            return;

        GameObject gameObject = UnityEngine.Object.Instantiate(prefab, transform);
        if (gameObject == null)
            return;

        Transform objectTransform = gameObject.transform;
        objectTransform.localPosition = Vector3.zero;
        Vector3 prefabScale = prefab.transform.localScale;
        objectTransform.localScale = new Vector3(
            prefabScale.x * orthoScale,
            prefabScale.y * orthoScale,
            prefabScale.z * orthoScale);

        Collider colliderInChildren = gameObject.GetComponentInChildren<Collider>();
        if (colliderInChildren != null)
            UnityEngine.Object.Destroy(colliderInChildren);

        Renderer[] renderers = gameObject.GetComponentsInChildren<Renderer>();
        Vector4 lightDirection = Vector4.zero;

        GameManager gameManager = Singleton<GameManager>.Instance;
        if (gameManager != null && gameManager.light != null)
        {
            Vector3 forward = gameManager.light.transform.forward;
            lightDirection = new Vector4(forward.x, forward.y, forward.z, 0f);
        }

        foreach (Renderer renderer in renderers)
        {
            if (renderer == null)
                continue;

            renderer.GetPropertyBlock(_propBlock);
            _propBlock.SetVector("_LightDirection", lightDirection);
            pb?.Invoke(_propBlock);
            renderer.SetPropertyBlock(_propBlock);
        }

        SetLayerRecursive(gameObject, renderLayer);

        renderCamera.orthographicSize = orthoScale;
        renderCamera.targetTexture = targetRT;
        renderCamera.Render();

        UnityEngine.Object.DestroyImmediate(gameObject);
    }

    private void RenderIcon(RenderTexture targetRT, float orthoScale)
    {
        if (renderCamera == null)
            return;

        renderCamera.orthographicSize = orthoScale;
        renderCamera.targetTexture = targetRT;
        renderCamera.Render();
    }

    private Sprite ConvertRenderTextureToSprite(
        RenderTexture rt,
        float pixelsPerUnit = 100f)
    {
        Texture2D texture2D = ConvertRenderTextureToTexture2D(rt);
        if (texture2D == null)
            throw new NullReferenceException(nameof(texture2D));

        Rect rect = new Rect(
            0f,
            0f,
            texture2D.width,
            texture2D.height);

        Vector2 pivot = new Vector2(0.5f, 0.5f);

        return Sprite.Create(
            texture2D,
            rect,
            pivot,
            pixelsPerUnit,
            0u,
            SpriteMeshType.FullRect);
    }

    private Texture2D ConvertRenderTextureToTexture2D(RenderTexture rt)
    {
        if (rt == null)
            return null;

        RenderTexture active = RenderTexture.active;
        RenderTexture.active = rt;

        Texture2D texture2D = new Texture2D(
            rt.width,
            rt.height,
            TextureFormat.RGBA32,
            false);

        try
        {
            Rect source = new Rect(
                0f,
                0f,
                rt.width,
                rt.height);

            texture2D.ReadPixels(source, 0, 0);
            texture2D.Apply();
            return texture2D;
        }
        finally
        {
            RenderTexture.active = active;
        }
    }

    private void SetLayerRecursive(GameObject obj, int layer)
    {
        if (obj == null)
            return;

        obj.layer = layer;

        Transform root = obj.transform;
        for (int i = 0; i < root.childCount; i++)
            SetLayerRecursive(root.GetChild(i).gameObject, layer);
    }

    private Texture2DArray CreateArrayFromTexture(Texture2D src)
    {
        if (src == null)
            return null;

        int mipmapCount = src.mipmapCount;
        bool mipChain = mipmapCount > 1;

        Texture2DArray texture2DArray = new Texture2DArray(
            src.width,
            src.height,
            1,
            TextureFormat.RGBA32,
            mipChain,
            false);

        for (int mip = 0; mip < mipmapCount; mip++)
        {
            Color32[] pixels = src.GetPixels32(mip);
            texture2DArray.SetPixels32(pixels, 0, mip);
        }

        texture2DArray.Apply(false, true);
        return texture2DArray;
    }

    public Texture2D SolidColor(
        Color32 color,
        int size = 1,
        bool mipChain = false)
    {
        size = Mathf.Max(1, size);

        Texture2D texture2D = new Texture2D(
            size,
            size,
            TextureFormat.RGBA32,
            mipChain);

        texture2D.wrapMode = TextureWrapMode.Clamp;
        texture2D.filterMode = FilterMode.Bilinear;
        texture2D.name = string.Format("SolidColor {0}", color);

        Color32[] pixels = new Color32[size * size];
        for (int i = 0; i < pixels.Length; i++)
            pixels[i] = color;

        texture2D.SetPixels32(pixels);
        texture2D.Apply(mipChain, true);
        texture2D.hideFlags = HideFlags.DontSave;

        return texture2D;
    }

    public UIIconGenerator()
    {
        renderLayer = 9;
        resolution = 256;
    }
}
