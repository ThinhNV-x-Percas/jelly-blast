using System;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Honey : FluidRendererBase
{
    private FluidSolver solver;
    private float fixedDeltaTime;

    public int[] solverIds;
    public int[] computeIds;

    public float particleSize = 0.8f;

    protected MaterialPropertyBlock _propBlock;

    public override void Init()
    {
        solver = Singleton<GameManager>.Instance.solver;
        fixedDeltaTime = Singleton<GameManager>.Instance.coupler.fixedDeltaTime;

        base.Init();

        solverIds = new int[maxParticles];
        computeIds = new int[maxParticles];

        _propBlock = new MaterialPropertyBlock();
        mr.GetPropertyBlock(_propBlock);
        _propBlock.SetInt("_FluidType", solver.honeyFluidType);
        mr.SetPropertyBlock(_propBlock);

        solver.OnStartRemoveParticles += OnSolverRemoveParticlesStart;
        solver.OnRemoveHoneyCoating += OnSolverRemoveParticlesStart;
    }

    public void AddSolverParticle(ParticleInitData solverContext)
    {
        if (!solver.isHoneyCoated[solverContext.Index] || activeCount >= solverIds.Length)
            return;

        solverIds[activeCount] = solverContext.Id;

        int computeId = IdGenerator.Next();
        computeIds[activeCount] = computeId;
        compute.AddParticle(computeId, ctx =>
        {
            compute.particleTypes[ctx.Index] = solver.honeyFluidType;
            compute.positions[ctx.Index] = solver.positions[solverContext.Index];
        });

        activeCount++;
    }

    public void OnSolverRemoveParticlesStart(HashSet<int> ids, bool explode)
    {
        foreach (int particleId in ids)
        {
            int index = Array.IndexOf(solverIds, particleId, 0, activeCount);
            if (index == -1)
                continue;

            compute.RemoveParticle(computeIds[index]);
        }

        int writeIndex = 0;
        for (int readIndex = 0; readIndex < activeCount; readIndex++)
        {
            if (ids.Contains(solverIds[readIndex]))
                continue;

            if (writeIndex != readIndex)
            {
                solverIds[writeIndex] = solverIds[readIndex];
                computeIds[writeIndex] = computeIds[readIndex];
                positions[writeIndex] = positions[readIndex];
                scales[writeIndex] = scales[readIndex];
            }
            writeIndex++;
        }
        activeCount = writeIndex;
    }

    public override void OnPreComputeUpdate()
    {
        if (activeCount >= 1)
        {
            float t = Mathf.Clamp01((Time.time - solver.lastStepWallTime) / fixedDeltaTime);

            for (int i = 0; i < activeCount; i++)
            {
                if (!solver.idToIndex.TryGetValue(solverIds[i], out int solverIndex))
                    continue;

                float2 currentPos = solver.positions[solverIndex];
                positions[i] = currentPos;
                scales[i] = particleSize * solver.scales[solverIndex];

                float2 prevPos = solver.positionsPrev[solverIndex];
                interpPositions[i] = prevPos + (currentPos - prevPos) * t;

                if (!compute.idToIndex.TryGetValue(computeIds[i], out int computeIndex))
                    continue;

                compute.positions[computeIndex] = interpPositions[i];
                compute.scales[computeIndex] = scales[i];
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
        {
            solver.OnStartRemoveParticles -= OnSolverRemoveParticlesStart;
            solver.OnRemoveHoneyCoating -= OnSolverRemoveParticlesStart;
        }

        base.OnDestroy();
    }
}
