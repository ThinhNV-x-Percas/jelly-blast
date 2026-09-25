using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class SpecialFluid : FluidRendererBase
{
    public int id;
    public FluidSolver solver;
    public int fluidType;

    protected internal MaterialPropertyBlock _propBlock;

    protected const float depthStride = 5E-06f;

    public HashSet<int> particleIds;

    public float zPos = -1f;

    public int[] solverIds;
    public int[] computeIds;

    public float particleSize = 0.8f;

    private float fixedDeltaTime;

    private void EnsureCapacity(int needed)
    {
        if (maxParticles > needed)
            return;

        int newSize = Mathf.NextPowerOfTwo(needed + 1);
        Array.Resize(ref solverIds, newSize);
        Array.Resize(ref computeIds, newSize);
        Array.Resize(ref positions, newSize);
        Array.Resize(ref interpPositions, newSize);
        Array.Resize(ref scales, newSize);
        maxParticles = newSize;
    }

    public virtual void Init(FluidSolver _solver, HashSet<int> _particleIds, int _fluidType, FluidCompute _compute)
    {
        solver = _solver;
        fixedDeltaTime = Singleton<GameManager>.Instance.coupler.fixedDeltaTime;
        fluidType = _fluidType;
        particleIds = _particleIds;
        compute = _compute;
        maxParticles = _particleIds.Count;
        solverIds = new int[maxParticles];
        computeIds = new int[maxParticles];

        base.Init();

        _propBlock = new MaterialPropertyBlock();
        mr.GetPropertyBlock(_propBlock);
        _propBlock.SetInt("_FluidType", fluidType);
        _propBlock.SetFloat("_Alpha", 1f);
        mr.SetPropertyBlock(_propBlock);

        solver.OnStartRemoveParticles += OnSolverRemoveParticlesStart;

        foreach (int particleId in particleIds)
            AddSolverParticle(particleId);
    }

    public IEnumerator HandlePopIn()
    {
        float startTime = Time.time;
        const float showDuration = 0.75f;

        while (Time.time < startTime + showDuration)
        {
            float t = (Time.time - startTime) / showDuration;
            SetScale(EasingFunction.EaseOutElastic(t, 1.75f, 0.3f));
            yield return null;
        }

        SetScale(1f);
    }

    public void Flash()
    {
    }

    private IEnumerator HandleFlash()
    {
        float startTime = Time.time;
        const float flashDuration = 0.2f;

        while (Time.time < startTime + flashDuration)
        {
            SetAlpha(Time.time);
            yield return null;
        }

        SetAlpha(Time.time);
    }

    public virtual void AddParticles(float2[] positionsToAdd)
    {
        if (solver == null)
            return;

        HashSet<int> addedIds = solver.AddParticles(positionsToAdd, fluidType);
        if (addedIds == null)
            return;

        foreach (int particleId in addedIds)
        {
            particleIds.Add(particleId);
            AddSolverParticle(particleId);
        }
    }

    public void AddSolverParticle(int id)
    {
        if (solver == null || compute == null || particleIds == null)
            return;

        EnsureCapacity(activeCount);
        solverIds[activeCount] = id;

        if (solver.idToIndex.TryGetValue(id, out int solverIndex))
        {
            positions[activeCount] = solver.positions[solverIndex];
            interpPositions[activeCount] = solver.positions[solverIndex];
            scales[activeCount] = particleSize * solver.scales[solverIndex];
        }

        int computeId = IdGenerator.Next();
        computeIds[activeCount] = computeId;

        int localIndex = activeCount;
        compute.AddParticle(computeId, ctx =>
        {
            // InitParticle defaults to fluid type 0. Every SpecialFluid must overwrite this;
            // otherwise its particles are rasterized into the wrong raw-field layer and the
            // SpecialFluid shader (which samples this type's layer/channel) sees an empty field.
            compute.particleTypes[ctx.Index] = fluidType;
            compute.positions[ctx.Index] = positions[localIndex];
            compute.scales[ctx.Index] = scales[localIndex];
        });

        activeCount++;
    }

    public virtual void OnSolverRemoveParticlesStart(HashSet<int> ids, bool explode)
    {
        foreach (int removedId in ids)
        {
            int index = Array.IndexOf(solverIds, removedId, 0, activeCount);
            if (index == -1)
                continue;

            compute.RemoveParticle(computeIds[index]);
        }

        int writeIndex = 0;
        for (int i = 0; i < activeCount; i++)
        {
            if (ids.Contains(solverIds[i]))
                continue;

            if (i != writeIndex)
            {
                solverIds[writeIndex] = solverIds[i];
                computeIds[writeIndex] = computeIds[i];
                positions[writeIndex] = positions[i];
                scales[writeIndex] = scales[i];
            }
            writeIndex++;
        }
        activeCount = writeIndex;
    }

    public override void OnPreComputeUpdate()
    {
        if (activeCount >= 1)
        {
            float alpha = Mathf.Clamp01((Time.time - solver.lastStepWallTime) / fixedDeltaTime);

            for (int i = 0; i < activeCount; i++)
            {
                if (!solver.idToIndex.TryGetValue(solverIds[i], out int slot))
                    continue;

                Vector2 currentPos = solver.positions[slot];
                Vector2 prevPos = solver.positionsPrev[slot];
                positions[i] = currentPos;
                interpPositions[i] = prevPos + (currentPos - prevPos) * alpha;
                scales[i] = particleSize * solver.scales[slot];

                if (!compute.idToIndex.TryGetValue(computeIds[i], out int gpuIndex))
                    continue;

                compute.positions[gpuIndex] = interpPositions[i];
                compute.scales[gpuIndex] = scales[i];
                float4 emission = solver.emissionColors[slot];
                compute.emissionColors[gpuIndex] = new Vector4(emission.x, emission.y, emission.z, emission.w);
            }
        }

        base.OnPreComputeUpdate();

        Camera main = Camera.main;
        Vector3 viewportPos = main.WorldToViewportPoint(new Vector3(position.x, position.y, 0f));
        Vector3 viewportMin = main.WorldToViewportPoint(new Vector3(min.x, min.y, 0f));
        Vector3 viewportMax = main.WorldToViewportPoint(new Vector3(max.x, max.y, 0f));

        mr.GetPropertyBlock(_propBlock);
        _propBlock.SetVector("_ViewportPos", new Vector4(viewportPos.x, viewportPos.y, viewportPos.z, 0f));
        _propBlock.SetVector("_ViewportSize", new Vector4(
            Mathf.Abs(viewportMax.x - viewportMin.x),
            Mathf.Abs(viewportMax.y - viewportMin.y),
            0f,
            0f));
        mr.SetPropertyBlock(_propBlock);
    }

    protected override void OnDestroy()
    {
        if (solver != null)
            solver.OnStartRemoveParticles -= OnSolverRemoveParticlesStart;

        base.OnDestroy();
    }

    private void SetScale(float scale)
    {
        if (particleIds == null || solver == null)
            return;

        foreach (int particleId in particleIds)
        {
            if (solver.idToIndex.TryGetValue(particleId, out int index))
                solver.scales[index] = scale;
        }
    }

    private void SetAlpha(float val)
    {
        if (particleIds == null || solver == null)
            return;

        foreach (int particleId in particleIds)
        {
            if (solver.idToIndex.TryGetValue(particleId, out int index))
                solver.emissionColors[index] = new float4(1f, 1f, 1f, val);
        }
    }
}
