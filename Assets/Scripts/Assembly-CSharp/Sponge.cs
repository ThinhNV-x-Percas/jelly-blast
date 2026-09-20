using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Mathematics;
using DG.Tweening;

/// <summary>
/// Reconstructed Sponge implementation from the supplied IL2CPP/AssetRipper output.
/// Invalid native/decompiler expressions have been replaced with normal C# while
/// preserving the recoverable gameplay flow:
/// - optional debug particle spawning with the S key;
/// - per-particle sponge rotation tracking;
/// - viewport/rotation shader data through MaterialPropertyBlock;
/// - water overlap detection;
/// - temporary disabling of water simulation;
/// - tweening water particles into the sponge;
/// - removing absorbed water particles and restoring the sponge pop-in state.
///
/// Two shader property names were not recoverable from the decompiled binary because
/// the metadata/string operands were corrupted. They are therefore exposed as
/// Inspector fields instead of inventing a hard-coded property ID.
/// </summary>
public class Sponge : SpecialFluid
{
    [Serializable]
    private sealed class SuckParticleTween
    {
        public int particleId;
        public int particleIndex;
        public HashSet<int> particleSet;
    }

    private readonly Dictionary<int, Vector2> prevOffset;

    public float zRotation;

    private HashSet<int> removedParticles;
    private bool isCleared;

    [Header("Sponge Shader Properties")]
    [Tooltip("Shader property receiving the sponge viewport position.")]
    [SerializeField]
    private string viewportProperty = "_SpongePosition";

    [Tooltip("Shader property receiving the sponge rotation vector.")]
    [SerializeField]
    private string rotationProperty = "_SpongeRotation";

    [Header("Sponge Water")]
    [Tooltip("Maximum distance from the sponge to a water particle before absorption starts.")]
    [SerializeField]
    private float waterSuckRadius = 0.1f;

    [Tooltip("Minimum duration of a water particle absorption tween.")]
    [SerializeField]
    private float suckDurationMin = 0.15f;

    [Tooltip("Maximum duration of a water particle absorption tween.")]
    [SerializeField]
    private float suckDurationMax = 0.3f;

    [Tooltip("Ease used by the reconstructed water absorption tween.")]
    [SerializeField]
    private Ease suckEase = Ease.InOutQuad;

    public void Init(
        FluidSolver _solver,
        HashSet<int> _particleIds,
        int _fluidType,
        FluidCompute _compute,
        int _id)
    {
        id = _id;
        base.Init(_solver, _particleIds, _fluidType, _compute);
    }

    private void Start()
    {
        isCleared = false;
    }

    public override void OnPreComputeUpdate()
    {
        // Recovered debug helper from the original method:
        // pressing S injects a new sponge particle at the current sponge position.
        if (Input.GetKeyDown(KeyCode.S) && solver != null)
        {
            Vector2 spawnPosition = position;

            float2[] spawnPositions =
            {
                new float2(spawnPosition.x, spawnPosition.y)
            };

            HashSet<int> addedIds = solver.AddParticles(
                spawnPositions,
                fluidType,
                ctx =>
                {
                    if (ctx.Index >= 0 && ctx.Index < solver.spongeIds.Length)
                        solver.spongeIds[ctx.Index] = id;
                });

            if (particleIds == null)
                particleIds = new HashSet<int>();

            particleIds.UnionWith(addedIds);
        }

        // The original method enters this particle loop only while the sponge
        // has not yet been cleared.
        if (!isCleared)
        {
            UpdateRotationFromParticleOffsets();
            DetectWaterCollision();
        }

        base.OnPreComputeUpdate();

        UpdateViewportShaderData();
        UpdateRotationShaderData();
    }

    private void UpdateRotationFromParticleOffsets()
    {
        if (solver == null || particleIds == null || particleIds.Count == 0)
            return;

        float accumulatedAngleDegrees = 0f;

        foreach (int particleId in particleIds)
        {
            if (!solver.idToIndex.TryGetValue(particleId, out int index))
                continue;

            if (index < 0 || index >= solver.positions.Length)
                continue;

            float2 particlePosition = solver.positions[index];
            Vector2 currentOffset = new Vector2(
                particlePosition.x - position.x,
                particlePosition.y - position.y);

            if (!prevOffset.TryGetValue(particleId, out Vector2 previousOffset))
            {
                prevOffset[particleId] = currentOffset;
                continue;
            }

            float previousLengthSq =
                previousOffset.x * previousOffset.x +
                previousOffset.y * previousOffset.y;

            float currentLengthSq =
                currentOffset.x * currentOffset.x +
                currentOffset.y * currentOffset.y;

            float denominator = Mathf.Sqrt(previousLengthSq * currentLengthSq);
            float angleDegrees = 0f;

            if (denominator >= 1e-15f)
            {
                float dot =
                    currentOffset.x * previousOffset.x +
                    currentOffset.y * previousOffset.y;

                float cosine = Mathf.Clamp(dot / denominator, -1f, 1f);
                angleDegrees = Mathf.Acos(cosine) * 57.29578f;

                float signedCross =
                    currentOffset.y * previousOffset.x -
                    currentOffset.x * previousOffset.y;

                if (signedCross < 0f)
                    angleDegrees = -angleDegrees;
            }

            accumulatedAngleDegrees += angleDegrees;
            prevOffset[particleId] = currentOffset;
        }

        // Native reconstruction:
        //   averageDegrees * (-PI / 180) -> zRotation
        zRotation +=
            (accumulatedAngleDegrees / particleIds.Count) *
            (-Mathf.PI / 180f);
    }

    private void UpdateViewportShaderData()
    {
        if (solver == null || mr == null || _propBlock == null)
            return;

        Camera main = Camera.main;
        if (main == null)
            return;

        if (!solver.spongeMidpoints.TryGetValue(id, out float2 midpoint))
            return;

        Vector3 worldPosition = new Vector3(midpoint.x, midpoint.y, 0f);
        Vector3 viewportPosition = main.WorldToViewportPoint(worldPosition);

        Vector4 value = new Vector4(
            viewportPosition.x,
            viewportPosition.y,
            viewportPosition.z,
            0f);

        if (!string.IsNullOrEmpty(viewportProperty) &&
            HasRendererProperty(viewportProperty))
        {
            mr.GetPropertyBlock(_propBlock);
            _propBlock.SetVector(viewportProperty, value);
            mr.SetPropertyBlock(_propBlock);
        }
    }

    private void UpdateRotationShaderData()
    {
        if (mr == null || _propBlock == null)
            return;

        Vector4 value = new Vector4(
            zRotation,
            zRotation,
            0f,
            0f);

        if (!string.IsNullOrEmpty(rotationProperty) &&
            HasRendererProperty(rotationProperty))
        {
            mr.GetPropertyBlock(_propBlock);
            _propBlock.SetVector(rotationProperty, value);
            mr.SetPropertyBlock(_propBlock);
        }
    }

    private bool HasRendererProperty(string propertyName)
    {
        Material sharedMaterial = mr.sharedMaterial;
        return sharedMaterial != null && sharedMaterial.HasProperty(propertyName);
    }

    private void DetectWaterCollision()
    {
        if (solver == null ||
            particleIds == null ||
            particleIds.Count == 0 ||
            removedParticles == null)
        {
            return;
        }

        Water[] waters = FindObjectsOfType<Water>();
        if (waters == null || waters.Length == 0)
            return;

        Vector2 spongePosition = position;
        float radiusSq = waterSuckRadius * waterSuckRadius;

        for (int w = 0; w < waters.Length; w++)
        {
            Water water = waters[w];
            if (water == null || water.particleIds == null)
                continue;

            foreach (int waterParticleId in water.particleIds)
            {
                if (removedParticles.Contains(waterParticleId))
                    continue;

                if (!solver.idToIndex.TryGetValue(waterParticleId, out int waterIndex))
                    continue;

                if (waterIndex < 0 || waterIndex >= solver.positions.Length)
                    continue;

                float2 particle = solver.positions[waterIndex];
                float dx = spongePosition.x - particle.x;
                float dy = spongePosition.y - particle.y;

                if (dx * dx + dy * dy >= radiusSq)
                    continue;

                isCleared = true;
                removedParticles.Add(waterParticleId);
                StartCoroutine(SuckUpWater(water));
                return;
            }
        }
    }

    private IEnumerator SuckUpWater(Water water)
    {
        if (water == null || solver == null || water.particleIds == null)
            yield break;

        // First pass from the recovered iterator state-machine:
        // water particles are taken out of the fluid simulation, then one frame
        // is yielded before the tween pass starts.
        foreach (int waterParticleId in water.particleIds)
        {
            if (!solver.idToIndex.TryGetValue(waterParticleId, out int index))
                continue;

            if (index < 0 || index >= solver.isSimulated.Length)
                continue;

            solver.isSimulated[index] = false;
        }

        yield return null;

        Vector2 targetPosition = position;

        foreach (int waterParticleId in water.particleIds)
        {
            if (!solver.idToIndex.TryGetValue(waterParticleId, out int particleIndex))
                continue;

            if (particleIndex < 0 || particleIndex >= solver.positions.Length)
                continue;

            int capturedIndex = particleIndex;
            var particleState = new SuckParticleTween
            {
                particleId = waterParticleId,
                particleIndex = capturedIndex,
                particleSet = new HashSet<int> { waterParticleId }
            };

            float durationMin = Mathf.Max(0f, suckDurationMin);
            float durationMax = Mathf.Max(durationMin, suckDurationMax);
            float duration = UnityEngine.Random.Range(durationMin, durationMax);

            DOTween.To(
                    () =>
                    {
                        if (capturedIndex < 0 ||
                            capturedIndex >= solver.positions.Length)
                        {
                            return targetPosition;
                        }

                        float2 value = solver.positions[capturedIndex];
                        return new Vector2(value.x, value.y);
                    },
                    value =>
                    {
                        if (capturedIndex < 0 ||
                            capturedIndex >= solver.positions.Length)
                        {
                            return;
                        }

                        solver.positions[capturedIndex] = new float2(value.x, value.y);
                    },
                    targetPosition,
                    duration)
                .SetEase(suckEase)
                .OnComplete(() =>
                {
                    removedParticles.Add(particleState.particleId);

                    // The decompiled state machine allocates a one-element
                    // HashSet for each tween before attaching the completion
                    // callback. The recoverable use of that set is to mark the
                    // absorbed particle as removed. Physical array compaction is
                    // deliberately not done here because all active tweens hold
                    // the original particle indices.
                    removedParticles.UnionWith(particleState.particleSet);
                });
        }

        // Recovered tail of the generated iterator:
        // once the suction pass has been launched, restore the sponge pop-in flow.
        StartCoroutine(HandlePopIn());
    }

    public Sponge()
    {
        prevOffset = new Dictionary<int, Vector2>();
        removedParticles = new HashSet<int>();
    }
}
