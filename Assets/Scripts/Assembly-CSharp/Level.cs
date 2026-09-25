using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class Level : MonoBehaviour
{
    [Header("Global settings")]
    public int moveCount = 20;
    public Color[] colors;
    public int numParticles = 512;
    public bool shouldSpawnParticles = true;
    public float levelWidth = 10f;
    public float triggerNextSectionDist = 3f;
    public bool disableAutoFishSpawning;

    [Header("Per-section settings")]
    public List<LevelSection> sections = new List<LevelSection>();

    [Header("Level-wide goals")]
    public List<GoalData> goals = new List<GoalData>();

    [Header("Bee Spawning")]
    [SerializeField]
    private bool enableBeeSpawning;

    [SerializeField]
    private int fluidCollectionThreshold = 5;

    [SerializeField]
    private Transform beeSpawnPoint;

    [SerializeField]
    private int maxBeesSpawned = 3;

    [SerializeField]
    private float beeSpawnRadius = 0.5f;

    private int fluidsCollectedSinceLastBee;
    private int totalFluidsCollected;
    private int beesSpawnedCount;

    private FluidSolver solver;

    [Header("Background")]
    public Color backgroundTopColor;
    public Color backgroundBottomColor;

    [Header("Gradient LUT")]
    [Tooltip("Pixels in the 1-D gradient texture")]
    public int gradientResolution = 256;

    private Texture2D gradientLUT;
    private float gradientStartY;
    private float gradientEndY;

    [Tooltip("Duration of the camera’s intro fly‑through (seconds)")]
    [Header("Intro animation")]
    public float introDuration = 3f;

    [Header("Fluid Spawn Settings")]
    public FluidSpawnMode fluidSpawnMode;

    [Tooltip("If using CustomRange, this is the min/max X for fluid spawn")]
    public Vector2 fluidSpawnXRange = new Vector2(-2f, 2f);

    [Header("Camera Fit Options")]
    public float sectionHeight = 8f;

    [Header("Background Material")]
    public Material sideBackgroundMaterial;

    private List<GameObject> leftBackgroundQuads = new List<GameObject>();
    private List<GameObject> rightBackgroundQuads = new List<GameObject>();

    public int currentSection;

    private bool introPlaying = true;

    public List<Block> blocks = new List<Block>();

    private float sideColliderSize = 1000f;

    public Transform bottomTransform;

    private float cameraTargetY = float.NaN;
    private Tween cameraMoveTween;

    private const float CameraMoveDuration = 1.2f;
    private const float SideBackgroundZ = -9f;

    public bool EnableBeeSpawning => enableBeeSpawning;
    public int FluidCollectionThreshold => fluidCollectionThreshold;
    public int FluidsCollectedSinceLastBee => fluidsCollectedSinceLastBee;
    public int TotalFluidsCollected => totalFluidsCollected;
    public int MaxBeesSpawned => maxBeesSpawned;
    public int BeesSpawnedCount => beesSpawnedCount;

    public float TotalLevelHeight
    {
        get
        {
            GetColliderYExtents(out float minY, out float maxY);
            return maxY - minY + 8f;
        }
    }

    public float LevelCenterY
    {
        get
        {
            GetColliderYExtents(out float minY, out float maxY);
            return (minY + maxY) * 0.5f;
        }
    }

    internal void GetColliderYExtents(out float minY, out float maxY)
    {
        minY = float.MaxValue;
        maxY = float.MinValue;

        foreach (LevelSection section in sections)
        {
            if (section.y < minY)
            {
                minY = section.y;
            }

            if (section.y > maxY)
            {
                maxY = section.y;
            }
        }

        foreach (Transform child in GetComponentsInChildren<Transform>(true))
        {
            Collider2D childCollider = child.GetComponent<Collider2D>();
            if (childCollider == null)
            {
                continue;
            }

            Bounds bounds = childCollider.bounds;
            if (bounds.min.y < minY)
            {
                minY = bounds.min.y;
            }

            if (bounds.max.y > maxY)
            {
                maxY = bounds.max.y;
            }
        }
    }

    public LevelSection GetCurrentSection()
    {
        return currentSection < sections.Count ? sections[currentSection] : null;
    }

    public float GetRandomFluidSpawnX()
    {
        if (fluidSpawnMode == FluidSpawnMode.CustomRange)
        {
            return Random.Range(fluidSpawnXRange.x, fluidSpawnXRange.y);
        }

        return Random.Range(-levelWidth * 0.5f, levelWidth * 0.5f);
    }

    public void Init()
    {
        solver = Singleton<GameManager>.Instance.solver;
        Singleton<GameManager>.Instance.targetParticleCount = numParticles;

        currentSection = 0;
        introPlaying = true;
        cameraTargetY = float.NaN;
        cameraMoveTween = null;

        if (sections.Count >= 1)
        {
            Camera mainCamera = Camera.main;
            float sectionWidth = sectionHeight * mainCamera.aspect;
            if (sectionWidth >= levelWidth)
            {
                mainCamera.orthographicSize = sectionHeight * 0.5f;
                mainCamera.GetComponent<HorizontalFOV>().targetWidth = sectionWidth;
            }
            else
            {
                mainCamera.GetComponent<HorizontalFOV>().targetWidth = levelWidth;
            }

            float sectionY = sections[0].y;
            mainCamera.transform.position = new Vector3(0f, sectionY, -10f);
            cameraTargetY = sectionY;
        }
        else
        {
            Camera.main.GetComponent<HorizontalFOV>().targetWidth = levelWidth;
        }

        float sideOffset = levelWidth * 0.5f + sideColliderSize * 0.5f;
        CreateSideCollider("LeftBoundary", -sideOffset);
        CreateSideCollider("RightBoundary", sideOffset);

        blocks.Clear();
        CollectBlocksRecursive(transform);
        AssignLocksToSections();
        UpdateBackgroundColors();
        InitializeBeeSpawning();

        StartCoroutine(IntroCameraAnimation());
        CreateSideBackgrounds();
    }

    private void CollectBlocksRecursive(Transform parent)
    {
        foreach (Transform child in parent)
        {
            Block block = child.GetComponent<Block>();
            if (block != null && block.gameObject.activeInHierarchy)
            {
                blocks.Add(block);
            }

            CollectBlocksRecursive(child);
        }
    }

    private void CreateSideCollider(string name, float xPos)
    {
        GameObject boundary = new GameObject(name);
        boundary.transform.position = new Vector3(xPos, 0f, 0f);
        BoxCollider2D boxCollider = boundary.AddComponent<BoxCollider2D>();
        boxCollider.size = new Vector2(sideColliderSize, sideColliderSize);
        boxCollider.isTrigger = false;
        boundary.isStatic = true;
    }

    // Establishing shot: pans the camera from the lowest to the highest section, then opens the intro screen.
    private IEnumerator IntroCameraAnimation()
    {
        Transform cam = Camera.main.transform;
        Vector3 initialPos = cam.position;
        float startTime;

        if (sections.Count >= 2)
        {
            yield return null;

            if (sections == null || sections.Count == 0)
            {
                introPlaying = false;
                yield break;
            }

            float startY = sections.Min(section => section.y);
            float endY = sections.Max(section => section.y);
            cam.position = new Vector3(initialPos.x, startY, initialPos.z);

            startTime = Time.time;
            while (Time.time - startTime < introDuration && Singleton<GameManager>.Instance._gameState == GameState.EstablishingShot)
            {
                float t = EasingFunction.EaseInOutSine((Time.time - startTime) / introDuration);
                cam.position = new Vector3(initialPos.x, Mathf.Lerp(startY, endY, t), initialPos.z);
                yield return null;
            }

            cam.position = new Vector3(initialPos.x, sections[0].y, initialPos.z);
        }
        else
        {
            startTime = Time.time;
            while (Time.time - startTime < 1f && Singleton<GameManager>.Instance._gameState == GameState.EstablishingShot)
            {
                yield return null;
            }

            yield return new WaitForSeconds(0.2f);
        }

        introPlaying = false;
        if (Singleton<GameManager>.Instance._gameState == GameState.EstablishingShot)
        {
            Singleton<GameManager>.Instance.StartIntroScreen();
        }
    }

    private void UpdateBackgroundColors()
    {
        gradientLUT = GenerateGradientLUT(gradientResolution);

        float halfHeight = TotalLevelHeight * 0.5f;
        gradientStartY = LevelCenterY - halfHeight;
        gradientEndY = halfHeight + LevelCenterY;

        float range = gradientEndY - gradientStartY;
        float rangeInv = range > 0.0001f ? 1f / range : 10000f;

        Shader.SetGlobalTexture("_GradientTex", gradientLUT);
        Shader.SetGlobalFloat("_GradientStartY", gradientStartY);
        Shader.SetGlobalFloat("_GradientRangeInv", rangeInv);
    }

    private Texture2D GenerateGradientLUT(int width)
    {
        HSBColor bottom = HSBColor.FromColor(backgroundBottomColor);
        HSBColor top = HSBColor.FromColor(backgroundTopColor);

        Texture2D texture = new Texture2D(width, 1, TextureFormat.RGBA32, false, true);
        texture.filterMode = FilterMode.Bilinear;
        texture.wrapMode = TextureWrapMode.Clamp;
        texture.name = "GradientLUT";

        int lastIndex = width - 1;
        for (int i = 0; i < width; i++)
        {
            float t = lastIndex > 0 ? (float)i / lastIndex : 0f;
            texture.SetPixel(i, 0, HSBColor.ToColor(HSBColor.Lerp(bottom, top, t)));
        }

        texture.Apply();
        return texture;
    }

    private void OnValidate()
    {
        UpdateBackgroundColors();
    }

    private void AssignLocksToSections()
    {
        // Sections that were assigned locks by hand in the prefab are left untouched.
        foreach (LevelSection section in sections)
        {
            if (section.locks.Count >= 1)
            {
                return;
            }
        }

        foreach (LevelSection section in sections)
        {
            section.locks.Clear();
        }

        if (sections.Count == 0)
        {
            return;
        }

        List<LevelSection> ordered = sections.OrderBy(section => section.y).ToList();
        List<float> boundaries = new List<float> { float.NegativeInfinity };
        for (int i = 0; i < ordered.Count - 1; i++)
        {
            boundaries.Add((ordered[i].y + ordered[i + 1].y) * 0.5f);
        }

        boundaries.Add(float.PositiveInfinity);

        foreach (Lock lockComponent in GetComponentsInChildren<Lock>(true))
        {
            float y = lockComponent.transform.position.y;
            for (int i = 0; i < ordered.Count; i++)
            {
                if (y >= boundaries[i] && y < boundaries[i + 1])
                {
                    ordered[i].locks.Add(lockComponent);
                    break;
                }
            }
        }
    }

    private void OnDrawGizmos()
    {
        if (sections == null)
        {
            return;
        }

        Gizmos.color = new Color(0f, 1f, 0f, 1f);
        Camera mainCamera = Camera.main;
        if (mainCamera == null)
        {
            return;
        }

        float height = levelWidth / mainCamera.aspect;
        foreach (LevelSection section in sections)
        {
            Gizmos.DrawWireCube(new Vector3(0f, section.y, 0f), new Vector3(levelWidth, height, 0.01f));
        }
    }

    private void InitializeBeeSpawning()
    {
        fluidsCollectedSinceLastBee = 0;
        totalFluidsCollected = 0;
        beesSpawnedCount = 0;
    }

    public void OnFluidCollected(int particleType)
    {
        if (!EnableBeeSpawning || solver == null)
        {
            fluidsCollectedSinceLastBee = 0;
            return;
        }

        if (particleType >= solver.colorFluidTypes)
        {
            return;
        }

        totalFluidsCollected++;
        fluidsCollectedSinceLastBee++;
        if (fluidsCollectedSinceLastBee >= FluidCollectionThreshold)
        {
            SpawnBee();
            fluidsCollectedSinceLastBee = 0;
        }
    }

    private void SpawnBee()
    {
        if (!EnableBeeSpawning || solver == null || beesSpawnedCount >= maxBeesSpawned)
        {
            return;
        }

        Vector2 center;
        if (beeSpawnPoint != null)
        {
            center = beeSpawnPoint.position;
        }
        else if (sections.Count >= 1)
        {
            center = new Vector2(0f, sections[currentSection].y);
        }
        else
        {
            center = transform.position;
        }

        float2[] positions = new float2[5];
        for (int i = 0; i < positions.Length; i++)
        {
            positions[i] = center + Random.insideUnitCircle * beeSpawnRadius * 0.5f;
        }

        solver.AddBee(positions);
        beesSpawnedCount++;
    }

    private void CreateSideBackgrounds()
    {
        foreach (GameObject quad in leftBackgroundQuads)
        {
            if (quad != null)
            {
                Destroy(quad);
            }
        }

        foreach (GameObject quad in rightBackgroundQuads)
        {
            if (quad != null)
            {
                Destroy(quad);
            }
        }

        leftBackgroundQuads.Clear();
        rightBackgroundQuads.Clear();

        if (sections.Count == 0 || sideBackgroundMaterial == null)
        {
            return;
        }

        Camera mainCamera = Camera.main;
        if (mainCamera == null)
        {
            return;
        }

        float cameraHeight = mainCamera.orthographicSize * 2f;
        float sideWidth = (cameraHeight * mainCamera.aspect - levelWidth) * 0.5f;
        if (sideWidth <= 0f)
        {
            return;
        }

        List<float> boundaries = GetSideBackgroundBoundaries(cameraHeight);
        for (int i = 0; i < boundaries.Count - 1; i++)
        {
            leftBackgroundQuads.Add(CreateSideBackgroundQuad(string.Format("LeftBackgroundSpan_{0}", i)));
            rightBackgroundQuads.Add(CreateSideBackgroundQuad(string.Format("RightBackgroundSpan_{0}", i)));
        }

        LayoutSideBackgrounds(boundaries, sideWidth);
    }

    private GameObject CreateSideBackgroundQuad(string name)
    {
        GameObject quad = GameObject.CreatePrimitive(PrimitiveType.Quad);
        quad.name = name;
        quad.transform.SetParent(transform, false);

        Renderer quadRenderer = quad.GetComponent<Renderer>();
        quadRenderer.material = sideBackgroundMaterial;
        quadRenderer.material.renderQueue = 4000;
        return quad;
    }

    private void LayoutSideBackgrounds(List<float> boundaries, float sideWidth)
    {
        float halfSideWidth = sideWidth * 0.5f;
        for (int i = 0; i < boundaries.Count - 1; i++)
        {
            float centerY = (boundaries[i] + boundaries[i + 1]) * 0.5f;
            Vector3 scale = new Vector3(sideWidth, boundaries[i + 1] - boundaries[i], 1f);

            Transform left = leftBackgroundQuads[i].transform;
            left.position = new Vector3(levelWidth * -0.5f - halfSideWidth, centerY, SideBackgroundZ);
            left.localScale = scale;

            Transform right = rightBackgroundQuads[i].transform;
            right.position = new Vector3(levelWidth * 0.5f + halfSideWidth, centerY, SideBackgroundZ);
            right.localScale = scale;
        }
    }

    private List<float> GetSideBackgroundBoundaries(float cameraHeight)
    {
        List<LevelSection> ordered = sections.OrderBy(section => section.y).ToList();
        List<float> boundaries = new List<float> { ordered.First().y - cameraHeight };
        for (int i = 0; i < ordered.Count - 1; i++)
        {
            boundaries.Add((ordered[i].y + ordered[i + 1].y) * 0.5f);
        }

        boundaries.Add(ordered.Last().y + cameraHeight);
        return boundaries;
    }

    private void Update()
    {
        if (introPlaying)
        {
            return;
        }

        if (sections.Count >= 1)
        {
            UpdateCameraFit();
        }

        if (currentSection >= sections.Count - 1)
        {
            return;
        }

        CheckAdvanceSection();

        int quadCount = sections.Count > 0 ? sections.Count + 1 : 0;
        if (leftBackgroundQuads.Count != quadCount || rightBackgroundQuads.Count != quadCount || sections.Count < 1)
        {
            return;
        }

        Camera mainCamera = Camera.main;
        float cameraHeight = mainCamera.orthographicSize * 2f;
        float sideWidth = (cameraHeight * mainCamera.aspect - levelWidth) * 0.5f;
        LayoutSideBackgrounds(GetSideBackgroundBoundaries(cameraHeight), sideWidth);
    }

    private void UpdateCameraFit()
    {
        Camera mainCamera = Camera.main;
        float sectionWidth = sectionHeight * mainCamera.aspect;
        float targetY = sections[Mathf.Clamp(currentSection, 0, sections.Count - 1)].y;

        if (sectionWidth >= levelWidth)
        {
            mainCamera.orthographicSize = sectionHeight * 0.5f;
            mainCamera.GetComponent<HorizontalFOV>().targetWidth = sectionWidth;
        }
        else
        {
            mainCamera.GetComponent<HorizontalFOV>().targetWidth = levelWidth;
        }

        if (Mathf.Approximately(cameraTargetY, targetY))
        {
            return;
        }

        cameraTargetY = targetY;
        if (cameraMoveTween != null && cameraMoveTween.IsActive())
        {
            cameraMoveTween.Kill();
        }

        cameraMoveTween = mainCamera.transform.DOMoveY(targetY, CameraMoveDuration).SetEase(Ease.InOutQuad);
    }

    // Moves on to the next section once the lowest coloured particle has fallen past the current one.
    private void CheckAdvanceSection()
    {
        float minY = float.MaxValue;
        for (int i = 0; i < solver.ActiveCount; i++)
        {
            if (solver.isWater[i] || solver.beeIds[i] != -1)
            {
                continue;
            }

            int type = solver.particleTypes[i];
            if (type == solver.mudFluidType || type == solver.snowFluidType)
            {
                continue;
            }

            minY = Mathf.Min(minY, solver.positions[i].y);
        }

        if (minY >= sections[currentSection].y - triggerNextSectionDist)
        {
            return;
        }

        currentSection++;
        float sectionY = sections[currentSection].y;
        Camera.main.transform.DOMoveY(sectionY, CameraMoveDuration)
            .SetEase(Ease.InOutQuad)
            .OnComplete(() =>
            {
                foreach (Block block in Singleton<GameManager>.Instance.level.GetComponentsInChildren<Block>(false))
                {
                    if (block.GetComponent<Rigidbody2D>().bodyType == RigidbodyType2D.Kinematic && block.transform.position.y > sectionY + 4f)
                    {
                        block.isCleared = true;
                        Destroy(block.gameObject);
                    }
                }

                solver.GetComponent<FluidPhysicsCoupler>().RefreshBodies();
            });
    }
}
