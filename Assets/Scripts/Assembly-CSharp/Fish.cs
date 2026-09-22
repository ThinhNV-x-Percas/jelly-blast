using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

/// <summary>
/// Reconstructed Fish implementation from the supplied IL2CPP/AssetRipper output.
/// Generated coroutine state-machines and invalid native/decompiler expressions
/// have been replaced with equivalent normal C# coroutines while preserving the
/// observable gameplay flow present in the source.
/// </summary>
public class Fish : SpecialFluid
{
    [Header("Movement")]
    public Transform fish;
    public float fishMoveMag;
    public float fishMoveFreq;
    public float fishMoveOffset;

    public Animator animator;
    public bool hasSwum;

    private Tween _danceTween;
    private Vector3 pendingCenter;
    private Vector3 pendingMenu;
    private Action m_OnMenuReached;

    [SerializeField]
    [Header("Ease Curves")]
    private AnimationCurve centerEase;

    [SerializeField]
    private AnimationCurve menuEase;

    [SerializeField]
    [Tooltip("Ease for the scale-up (0→1 over the first leg)")]
    [Header("Scale Settings")]
    private AnimationCurve scaleEase;

    [SerializeField]
    [Header("Face Blend-Shapes")]
    private SkinnedMeshRenderer faceRenderer;

    [SerializeField]
    [Header("Dive Settings")]
    private float diveAngle;

    [SerializeField]
    private float fallWaitTime;

    [SerializeField]
    [Header("Dive & Rise Durations")]
    private float riseRotationDuration;

    [SerializeField]
    [Header("Move Durations")]
    private float centerMoveDuration;

    private float menuMoveDuration;

    [SerializeField]
    [Tooltip("How much bigger the fish gets at centre (1 = no change)")]
    [Header("Scale Multipliers")]
    private float growScaleMultiplier;

    [SerializeField]
    [Tooltip("How small the fish should be when it hits the menu (1 = no change)")]
    private float shrinkScaleMultiplier;

    private bool _isFinalFish;

    public bool isBig;

    /// <summary>
    /// The original generated event accessors were corrupted by decompilation.
    /// A normal C# event preserves the same public API and semantics.
    /// </summary>
    public event Action OnMenuReached
    {
        add => m_OnMenuReached += value;
        remove => m_OnMenuReached -= value;
    }

    public void PlayHitWaterAnimation(Vector3 worldMenuTarget)
    {
        // Native source explicitly guards against the animation being started twice.
        if (hasSwum)
            return;

        hasSwum = true;
        pendingMenu = worldMenuTarget;

        Camera main = Camera.main;
        if (main != null)
        {
            Vector3 viewportPoint = main.WorldToViewportPoint(fish.position);
            viewportPoint.x = 0.5f;
            viewportPoint.y = 0.5f;
            viewportPoint.z -= 6f;
            pendingCenter = main.ViewportToWorldPoint(viewportPoint);
        }
        else
        {
            // Keep the animation usable even if there is no Main Camera.
            pendingCenter = fish.position;
        }

        // Matches the recovered native flow: face changes -> swim animation -> dive rotation.
        if (faceRenderer != null)
        {
            faceRenderer.SetBlendShapeWeight(1, 100f);
            faceRenderer.SetBlendShapeWeight(2, 0f);
        }

        SetAnimatorSwim(true);

        Quaternion localRotation = fish.localRotation;
        Quaternion diveRotation = localRotation *
                                  Quaternion.Euler(diveAngle, 0f, 0f);

        fish.DOLocalRotateQuaternion(diveRotation, 0.2f)
            .SetEase(Ease.OutQuad);

        // The IL2CPP code was trying to complete FluidSolver's current job before
        // creating the coroutine. The public method in the repaired FluidSolver is
        // used instead of illegally accessing its private JobHandle.
        if (solver != null)
            solver.LastJobComplete();

        StartCoroutine(FallThenFly(localRotation));
    }

    public void SetFinalFish(bool isFinal)
    {
        _isFinalFish = isFinal;
    }

    private bool IsInWater()
    {
        if (solver == null || particleIds == null || particleIds.Count == 0)
            return false;

        // Native reconstruction:
        // particleIds -> solver.idToIndex -> solver.waterDensities[index] > 0.
        foreach (int particleId in particleIds)
        {
            if (!solver.idToIndex.TryGetValue(particleId, out int index))
                continue;

            if (!solver.waterDensities.IsCreated)
                return false;

            if (index < 0 || index >= solver.waterDensities.Length)
                continue;

            if (solver.waterDensities[index] > 0f)
                return true;
        }

        return false;
    }

    private IEnumerator FallThenFly(Quaternion uprightRot)
    {
        float elapsed = 0f;
        bool leftWaterEarly = false;

        // Recovered source waits while the fish is still in water, bounded by
        // fallWaitTime. If the fish leaves the water before that time is up, the
        // whole "fly to menu" animation is aborted and the fish just returns to
        // its normal swimming state (this matches the native reconstruction,
        // which jumps straight to the abort path the first frame the fish is
        // found out of water).
        if (fallWaitTime > 0f)
        {
            while (true)
            {
                if (!IsInWater())
                {
                    leftWaterEarly = true;
                    break;
                }

                if (elapsed >= fallWaitTime)
                    break;

                elapsed += Time.deltaTime;
                yield return null;
            }
        }

        if (leftWaterEarly)
        {
            hasSwum = false;

            SetAnimatorSwim(false);

            if (faceRenderer != null)
            {
                faceRenderer.SetBlendShapeWeight(1, 0f);
                faceRenderer.SetBlendShapeWeight(2, 100f);
            }

            m_OnMenuReached = null;

            fish.DOLocalRotateQuaternion(uprightRot, 0.1f)
                .SetEase(Ease.OutQuad);

            yield break;
        }

        // The original code removes all solver particles before the final
        // centre/menu animation.
        if (solver != null && particleIds != null)
            solver.RemoveParticles(particleIds);

        if (mr != null)
            mr.enabled = false;

        // The recovered native flow also promotes a fish to "final fish" once the
        // last displayed Fish goal is about to be completed, even if SetFinalFish
        // was never explicitly called on it.
        if (!_isFinalFish)
        {
            GoalData goalData = Singleton<GameManager>.Instance.level.goals.Find((GoalData g) => g.goalType == GoalType.Fish);
            if (goalData != null && goalData.displayedCount + 1 >= goalData.count)
            {
                _isFinalFish = true;
            }
        }

        Vector3 baseScale = fish.localScale;
        Vector3 centerScale = baseScale * growScaleMultiplier;
        Vector3 menuScale = baseScale * shrinkScaleMultiplier;

        float rotationDuration = Mathf.Max(0f, riseRotationDuration);
        float centerDuration = Mathf.Max(0f, centerMoveDuration);
        float menuDuration = Mathf.Max(0f, menuMoveDuration);

        // The original native code has a two-stage "rise / centre / menu" sequence.
        // Preserve that structure using the recovered target positions and scale fields.
        Sequence sequence = DOTween.Sequence();

        if (_isFinalFish)
        {
            // The recovered native path performs a longer, multi-stage rise (dive,
            // then rise, then back upright while growing) when this is the final fish.
            float halfRise = rotationDuration * 0.3f;
            float riseDuration = halfRise + halfRise;
            float centerDone = centerDuration + riseDuration;

            sequence.Append(
                fish.DOMove(pendingCenter, centerDone)
                    .SetEase(centerEase)
            );

            if (rotationDuration > 0f)
            {
                sequence.Insert(
                    0f,
                    fish.DOLocalRotateQuaternion(
                        uprightRot * Quaternion.Euler(-20f, 0f, 0f),
                        halfRise
                    ).SetEase(Ease.OutQuad)
                );

                sequence.Insert(
                    halfRise,
                    fish.DOLocalRotateQuaternion(
                        uprightRot * Quaternion.Euler(-45f, 0f, 0f),
                        halfRise
                    ).SetEase(Ease.OutQuad)
                );

                sequence.Insert(
                    riseDuration,
                    fish.DOLocalRotateQuaternion(
                        uprightRot,
                        centerDuration
                    ).SetEase(Ease.InOutSine)
                );
            }

            sequence.Insert(
                riseDuration,
                fish.DOScale(centerScale, centerDuration)
                    .SetEase(scaleEase)
            );

            sequence.Append(
                fish.DOMove(pendingMenu, menuDuration)
                    .SetEase(menuEase)
            );

            sequence.Join(
                fish.DOScale(menuScale, menuDuration)
                    .SetEase(menuEase)
            );

            // The final fish also rotates flat while it moves in to the menu goal icon.
            sequence.Join(
                fish.DOLocalRotateQuaternion(Quaternion.Euler(-45f, 0f, 0f), menuDuration)
                    .SetEase(menuEase)
            );
        }
        else
        {
            sequence.Append(
                fish.DOMove(pendingCenter, centerDuration)
                    .SetEase(centerEase)
            );

            sequence.Join(
                fish.DOScale(centerScale, centerDuration)
                    .SetEase(scaleEase)
            );

            sequence.Append(
                fish.DOMove(pendingMenu, menuDuration)
                    .SetEase(menuEase)
            );

            sequence.Join(
                fish.DOScale(menuScale, menuDuration)
                    .SetEase(menuEase)
            );
        }

        sequence.OnComplete(() =>
        {
            m_OnMenuReached?.Invoke();
        });
    }

    public override void OnPreComputeUpdate()
    {
        base.OnPreComputeUpdate();

        if (fish == null)
            return;

        if (hasSwum)
        {
            // Native reconstruction: while the fish has swum, the z-scale is kept in
            // step with the DOScale tween driving x/y (see FallThenFly), following the
            // recovered "(x + y) * 0.5" relationship from the decompiled output. The
            // exact secondary constant folded into that expression could not be
            // recovered, so it is treated as 1 (a no-op multiplier).
            Vector3 localScale = fish.localScale;
            fish.localScale = new Vector3(localScale.x, localScale.y, (localScale.x + localScale.y) * 0.5f);
            return;
        }

        float time = Time.time * fishMoveFreq + fishMoveOffset;

        // Native code uses sinusoidal components multiplied by fishMoveMag.
        // Use the standard Unity sine/cosine form represented by the recovered
        // Unity.Mathematics sin/cos calls.
        Vector3 localPosition = new Vector3(
            fishMoveMag * Mathf.Sin(time),
            fishMoveMag * Mathf.Cos(time),
            fishMoveMag * Mathf.Sin(time)
        );

        fish.localPosition = localPosition;
    }

    public void Init(
        FluidSolver _solver,
        int _id,
        HashSet<int> _particleIds,
        int _fluidType,
        FluidCompute _compute,
        Material _material,
        bool _isBig)
    {
        id = _id;

        if (mr != null)
            mr.material = _material;

        isBig = _isBig;
        fishMoveOffset = UnityEngine.Random.Range(0f, 360f);

        base.Init(_solver, _particleIds, _fluidType, _compute);
    }

    public IEnumerator RotateBlob()
    {
        float startTime = Time.time;
        const float duration = 0.35f;
        float endTime = startTime + duration;

        while (Time.time < endTime)
        {
            float t = Mathf.Clamp01((Time.time - startTime) / duration);
            float eased = EasingFunction.EaseOutQuad(t);
            float rot = (eased - 1f) * 0.5f;

            SetRotationProperty(rot);

            yield return null;
        }

        SetRotationProperty(1f);
    }

    public Fish()
    {
        centerEase = AnimationCurve.EaseInOut(0f, 0f, 1f, 1f);
        menuEase = AnimationCurve.Linear(0f, 0f, 1f, 1f);
        scaleEase = AnimationCurve.EaseInOut(0f, 0f, 1f, 1f);

        // The exact serialized native constant for diveAngle could not be recovered
        // from the supplied output. Keep a neutral default instead of the invalid
        // zeroed/native-memory expression.
        diveAngle = 0f;
        menuMoveDuration = 0.8f;
        growScaleMultiplier = 1f;
        shrinkScaleMultiplier = 0.5f;

        // These three values belong to SpecialFluid in the original layout, but were
        // initialized by Fish's constructor in the recovered output.
        zPos = -1f;
        particleSize = 0.8f;
        particleBoundsRadius = 0.4f;
    }

    private void SetRotationProperty(float rot)
    {
        if (mr == null || _propBlock == null)
            return;

        mr.GetPropertyBlock(_propBlock);

        // The original shader property string was lost to an invalid metadata-string
        // reference. "_Rotation" preserves the recovered intent: a float material
        // property driven from 0 -> 1 during the blob-rotation animation.
        _propBlock.SetFloat("_Rotation", rot);

        mr.SetPropertyBlock(_propBlock);
    }

    private void SetAnimatorSwim(bool value)
    {
        if (animator == null)
            return;

        // The decompiler resolved the original metadata pointer to an unrelated
        // UI string ("Scrollbar Horizontal"). The FIshAnimation.controller asset
        // confirms the real parameter name is "Swim"; try the most likely semantic
        // names without throwing when the controller does not contain one.
        AnimatorControllerParameter[] parameters = animator.parameters;

        for (int i = 0; i < parameters.Length; ++i)
        {
            AnimatorControllerParameter parameter = parameters[i];

            if (parameter.type != AnimatorControllerParameterType.Bool)
                continue;

            if (string.Equals(parameter.name, "Swim", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(parameter.name, "IsSwim", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(parameter.name, "HasSwum", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(parameter.name, "Swimming", StringComparison.OrdinalIgnoreCase))
            {
                animator.SetBool(parameter.name, value);
                return;
            }
        }
    }
}
