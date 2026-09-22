using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class FluidCompute : MonoBehaviour
{
    public int layerCount;
    public int maxParticles;
    public int activeCount;

    protected CommandBuffer cmd;

    public Vector2[] positions;
    public float[] particleTypes;
    public float[] isRounded;
    public Vector4[] emissionColors;
    public float[] scales;
    public float[] innerRadii;

    [HideInInspector]
    public int[] particleIds;

    public Dictionary<int, int> idToIndex;

    private int nextId;

    [Header("Particle Rendering")]
    public Mesh quadMesh;
    protected Matrix4x4[] particleMatrices;
    public Material particlesMaterial;
    public Material emissionMaterial;
    public RenderTexture emissionRT;
    public RenderTexture rawFieldRT;
    protected MaterialPropertyBlock props;

    [Header("Compute Shader Pass")]
    public ComputeShader fluidCS;
    public RenderTexture fluidRT;
    public float rawFieldDownscale;
    public float fieldDownscale;

    protected int W;
    protected int H;
    protected int rawW;
    protected int rawH;

    private int kMerge;
    private int tx;
    private int ty;

    private Vector4[] colorsVec;

    public Action OnPreUpdate;

    private void Awake()
    {
        GameManager gameManager = Singleton<GameManager>.Instance;
        if (gameManager != null)
        {
            gameManager.OnInit += OnInit;
        }
    }

    public virtual void OnInit()
    {
        rawW = (int)(rawFieldDownscale * Screen.width);
        rawH = (int)(rawFieldDownscale * Screen.height);
        W = (int)(fieldDownscale * Screen.width);
        H = (int)(fieldDownscale * Screen.height);

        EnsureRenderTextureArray(ref rawFieldRT, rawW, rawH, layerCount, true);
        EnsureRenderTexture2D(ref fluidRT, W, H);
        EnsureRenderTexture2D(ref emissionRT, rawW, rawH);

        if (cmd != null)
        {
            cmd.Release();
        }

        cmd = new CommandBuffer
        {
            name = "FluidCompute"
        };

        kMerge = -1;
        tx = 0;
        ty = 0;

        if (fluidCS != null && SystemInfo.supportsComputeShaders)
        {
            if (fluidCS.HasKernel("MergeField"))
            {
                kMerge = fluidCS.FindKernel("MergeField");
                tx = Mathf.CeilToInt(W / 8f);
                ty = Mathf.CeilToInt(H / 8f);
            }
            else
            {
                Debug.LogError("FluidCompute: FluidCS does not contain the MergeField kernel.");
            }
        }
        else
        {
            Debug.LogError(
                fluidCS == null
                    ? "FluidCompute: FluidCS is not assigned."
                    : "FluidCompute: compute shaders are not supported on this device.");
        }

        Camera mainCamera = Camera.main;
        if (mainCamera != null)
        {
            mainCamera.AddCommandBuffer(CameraEvent.BeforeImageEffectsOpaque, cmd);
        }

        particleIds = new int[maxParticles];
        positions = new Vector2[maxParticles];
        particleTypes = new float[maxParticles];
        isRounded = new float[maxParticles];
        emissionColors = new Vector4[maxParticles];
        scales = new float[maxParticles];
        innerRadii = new float[maxParticles];

        GameManager gameManager = Singleton<GameManager>.Instance;
        int colorCount = 0;

        if (gameManager != null && gameManager.solver != null)
        {
            colorCount = gameManager.solver.colorFluidTypes;
        }

        colorsVec = new Vector4[colorCount];
        particleMatrices = new Matrix4x4[maxParticles];
        props = new MaterialPropertyBlock();

        idToIndex ??= new Dictionary<int, int>();
    }

    public void LateUpdate()
    {
        if (cmd == null || fluidCS == null || rawFieldRT == null || fluidRT == null || emissionRT == null)
        {
            return;
        }

        OnPreUpdate?.Invoke();
        cmd.Clear();

        int renderCount = Mathf.Clamp(activeCount, 0, maxParticles);

        for (int i = 0; i < renderCount; i++)
        {
            Vector2 position = positions[i];
            float scale = scales[i];

            Vector3 pos = new Vector3(position.x, position.y, 0f);
            Vector3 size = new Vector3(scale, scale, scale);

            particleMatrices[i] = Matrix4x4.TRS(
                pos,
                Quaternion.identity,
                size);
        }

        props.SetVectorArray("_EmissionColors", emissionColors);

        cmd.SetRenderTarget(
            emissionRT,
            RenderBufferLoadAction.DontCare,
            RenderBufferStoreAction.Store,
            RenderBufferLoadAction.DontCare,
            RenderBufferStoreAction.DontCare);

        cmd.ClearRenderTarget(true, true, Color.clear);

        if (renderCount > 0 && quadMesh != null && emissionMaterial != null)
        {
            cmd.DrawMeshInstanced(
                quadMesh,
                0,
                emissionMaterial,
                0,
                particleMatrices,
                renderCount,
                props);
        }

        props.SetFloatArray("_ParticleTypes", particleTypes);
        props.SetFloatArray("_IsRounded", isRounded);
        props.SetFloatArray("_InnerRadii", innerRadii);

        if (quadMesh != null && particlesMaterial != null)
        {
            for (int layer = 0; layer < layerCount; layer++)
            {
                RenderTargetIdentifier renderTargetIdentifier =
                    new RenderTargetIdentifier(
                        rawFieldRT,
                        0,
                        CubemapFace.Unknown,
                        layer);

                cmd.SetRenderTarget(
                    renderTargetIdentifier,
                    RenderBufferLoadAction.DontCare,
                    RenderBufferStoreAction.Store,
                    RenderBufferLoadAction.DontCare,
                    RenderBufferStoreAction.DontCare);

                cmd.ClearRenderTarget(true, true, Color.clear);
                cmd.SetGlobalInt("_Layer", layer);

                if (renderCount > 0)
                {
                    cmd.DrawMeshInstanced(
                        quadMesh,
                        0,
                        particlesMaterial,
                        0,
                        particleMatrices,
                        renderCount,
                        props);
                }
            }
        }

        // These property names match the recovered FluidCS.compute shader.
        cmd.SetComputeTextureParam(fluidCS, kMerge, "_RawFieldTex", rawFieldRT);
        cmd.SetComputeTextureParam(fluidCS, kMerge, "_FluidOutputTex", fluidRT);

        cmd.SetComputeVectorParam(
            fluidCS,
            "_TexSize",
            new Vector4(W, H, 0f, 0f));

        cmd.SetComputeVectorParam(
            fluidCS,
            "_InvTexSize",
            new Vector4(
                rawW > 0 ? 1f / rawW : 0f,
                rawH > 0 ? 1f / rawH : 0f,
                0f,
                0f));

        cmd.SetComputeIntParam(fluidCS, "_LayerCount", layerCount);

        GameManager gameManager = Singleton<GameManager>.Instance;
        if (colorsVec != null)
        {
            Color[] levelColors =
                gameManager != null &&
                gameManager.level != null
                    ? gameManager.level.colors
                    : null;

            if (levelColors != null)
            {
                int count = Mathf.Min(colorsVec.Length, levelColors.Length);

                for (int i = 0; i < count; i++)
                {
                    colorsVec[i] = levelColors[i];
                }
            }

            if (colorsVec.Length > 0)
            {
                cmd.SetComputeVectorArrayParam(
                    fluidCS,
                    "_FluidColors",
                    colorsVec);
            }
        }

        if (tx > 0 && ty > 0)
        {
            cmd.DispatchCompute(fluidCS, kMerge, tx, ty, 1);
        }
    }

    public virtual void OnDestroy()
    {
        GameManager gameManager = Singleton<GameManager>.Instance;
        if (gameManager != null)
        {
            gameManager.OnInit -= OnInit;
        }

        Camera mainCamera = Camera.main;
        if (mainCamera != null && cmd != null)
        {
            mainCamera.RemoveCommandBuffer(CameraEvent.BeforeImageEffectsOpaque, cmd);
        }

        ReleaseRenderTexture(ref rawFieldRT);
        ReleaseRenderTexture(ref fluidRT);
        ReleaseRenderTexture(ref emissionRT);

        if (cmd != null)
        {
            cmd.Release();
            cmd = null;
        }
    }

    public void AddParticles(HashSet<int> ids, Action<ParticleInitData> onInit = null)
    {
        if (ids == null || ids.Count == 0)
        {
            return;
        }

        int slot = activeCount;
        int index = 0;

        foreach (int id in ids)
        {
            if (slot >= maxParticles)
            {
                Debug.LogError("FluidCompute particle capacity exceeded.");
                break;
            }

            InitParticle(id, slot);

            onInit?.Invoke(new ParticleInitData(slot, id, index));

            slot++;
            index++;
        }

        activeCount = Mathf.Min(slot, maxParticles);
    }

    public void AddParticle(int id, Action<ParticleInitData> onInit = null)
    {
        if (activeCount >= maxParticles)
        {
            Debug.LogError("FluidCompute particle capacity exceeded.");
            return;
        }

        int slot = activeCount;
        InitParticle(id, slot);

        onInit?.Invoke(new ParticleInitData(slot, id, 0));

        activeCount++;
    }

    public void InitParticle(int id, int slot)
    {
        if (particleIds == null ||
            positions == null ||
            particleTypes == null ||
            isRounded == null ||
            emissionColors == null ||
            scales == null ||
            innerRadii == null ||
            idToIndex == null)
        {
            return;
        }

        if (slot < 0 || slot >= particleIds.Length)
        {
            Debug.Log("InitParticle slot out of range: " + slot);
            return;
        }

        particleIds[slot] = id;
        positions[slot] = Vector2.zero;
        particleTypes[slot] = 0f;
        isRounded[slot] = 0f;
        emissionColors[slot] = Vector4.zero;
        scales[slot] = 1f;
        innerRadii[slot] = 0f;

        idToIndex[id] = slot;
    }

    public void RemoveParticles(HashSet<int> ids)
    {
        if (ids == null || ids.Count == 0 || particleIds == null)
        {
            return;
        }

        foreach (int id in ids)
        {
            idToIndex?.Remove(id);
        }

        int writeIndex = 0;
        int count = Mathf.Min(activeCount, particleIds.Length);

        for (int i = 0; i < count; i++)
        {
            int id = particleIds[i];

            if (ids.Contains(id))
            {
                continue;
            }

            if (i != writeIndex)
            {
                particleIds[writeIndex] = particleIds[i];
                positions[writeIndex] = positions[i];
                particleTypes[writeIndex] = particleTypes[i];
                isRounded[writeIndex] = isRounded[i];
                emissionColors[writeIndex] = emissionColors[i];
                scales[writeIndex] = scales[i];
                innerRadii[writeIndex] = innerRadii[i];
            }

            idToIndex[particleIds[writeIndex]] = writeIndex;
            writeIndex++;
        }

        activeCount = writeIndex;
    }

    public void RemoveParticle(int id)
    {
        HashSet<int> ids = new HashSet<int> { id };
        RemoveParticles(ids);
    }

    private static void EnsureRenderTexture2D(ref RenderTexture texture, int width, int height)
    {
        width = Mathf.Max(1, width);
        height = Mathf.Max(1, height);

        if (texture == null)
        {
            texture = new RenderTexture(width, height, 0, default(RenderTextureFormat));
        }

        bool needsRecreate =
            texture.width != width ||
            texture.height != height ||
            texture.dimension != TextureDimension.Tex2D;

        if (!needsRecreate && texture.IsCreated())
        {
            return;
        }

        if (texture.IsCreated())
        {
            texture.Release();
        }

        texture.width = width;
        texture.height = height;
        texture.dimension = TextureDimension.Tex2D;
        texture.volumeDepth = 1;
        texture.enableRandomWrite = true;
        texture.filterMode = FilterMode.Trilinear;
        texture.Create();
    }

    private static void EnsureRenderTextureArray(
        ref RenderTexture texture,
        int width,
        int height,
        int depth,
        bool randomWrite)
    {
        width = Mathf.Max(1, width);
        height = Mathf.Max(1, height);
        depth = Mathf.Max(1, depth);

        if (texture == null)
        {
            texture = new RenderTexture(width, height, 0, default(RenderTextureFormat));
        }

        bool needsRecreate =
            texture.width != width ||
            texture.height != height ||
            texture.volumeDepth != depth ||
            texture.dimension != TextureDimension.Tex2DArray;

        if (!needsRecreate && texture.IsCreated())
        {
            return;
        }

        if (texture.IsCreated())
        {
            texture.Release();
        }

        texture.width = width;
        texture.height = height;
        texture.dimension = TextureDimension.Tex2DArray;
        texture.volumeDepth = depth;
        texture.enableRandomWrite = randomWrite;
        texture.filterMode = FilterMode.Trilinear;
        texture.Create();
    }

    private static void ReleaseRenderTexture(ref RenderTexture texture)
    {
        if (texture == null)
        {
            return;
        }

        if (texture.IsCreated())
        {
            texture.Release();
        }

        texture = null;
    }

    public FluidCompute()
    {
        layerCount = 8;
        maxParticles = 512;
        idToIndex = new Dictionary<int, int>();
        rawFieldDownscale = 0.125f;
        fieldDownscale = 0.25f;
    }
}
