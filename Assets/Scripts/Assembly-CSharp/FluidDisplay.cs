using System.Collections.Generic;
using UnityEngine;
using Unity.Mathematics;

public class FluidDisplay : FluidRendererBase
{
    private FluidSolver solver;
    private float fixedDeltaTime;

    public float particleSize = 0.2f;
    public int[] particleIds;

    public override void Init()
    {
        base.Init();

        particleIds = new int[maxParticles];

        GameManager gameManager = Singleton<GameManager>.Instance;
        solver = gameManager != null ? gameManager.solver : null;

        // The solver steps at the coupler's fixed timestep, not Unity's physics timestep.
        fixedDeltaTime = gameManager != null && gameManager.coupler != null
            ? gameManager.coupler.fixedDeltaTime
            : Time.fixedDeltaTime;

        if (solver != null)
        {
            solver.OnAddParticles -= OnSolverAddParticles;
            solver.OnStartRemoveParticles -= OnSolverRemoveParticlesStart;
            solver.OnAddParticles += OnSolverAddParticles;
            solver.OnStartRemoveParticles += OnSolverRemoveParticlesStart;
        }
    }

    public void OnSolverAddParticles(HashSet<int> ids)
    {
        if (ids == null || solver == null)
            return;

        foreach (int id in ids)
        {
            if (!solver.idToIndex.TryGetValue(id, out int index))
                continue;

            if (solver.particleTypes[index] >= solver.colorFluidTypes)
                continue;

            if (activeCount >= particleIds.Length)
                break;

            particleIds[activeCount] = id;
            compute.AddParticle(id);
            activeCount++;
        }
    }

    public void OnSolverRemoveParticlesStart(HashSet<int> ids, bool explode)
    {
        if (compute != null && ids != null)
            compute.RemoveParticles(ids);

        if (activeCount < 1)
        {
            activeCount = 0;
            return;
        }

        int writeIndex = 0;

        for (int readIndex = 0; readIndex < activeCount; readIndex++)
        {
            int id = particleIds[readIndex];

            if (ids != null && ids.Contains(id))
                continue;

            if (readIndex != writeIndex)
            {
                positions[writeIndex] = positions[readIndex];
                scales[writeIndex] = scales[readIndex];
                particleIds[writeIndex] = particleIds[readIndex];
            }

            writeIndex++;
        }

        activeCount = writeIndex;
    }

    public override void OnPreComputeUpdate()
    {
        float time = Time.time;

        if (solver != null && activeCount >= 1)
        {
            float t = fixedDeltaTime > 0f
                ? Mathf.Clamp01((time - solver.lastStepWallTime) / fixedDeltaTime)
                : 0f;

            for (int i = 0; i < activeCount; i++)
            {
                int id = particleIds[i];

                if (!solver.idToIndex.TryGetValue(id, out int solverIndex))
                    continue;

                float2 currentPos = solver.positions[solverIndex];
                positions[i] = currentPos;
                scales[i] = particleSize * solver.scales[solverIndex];

                float2 prevPos = solver.positionsPrev[solverIndex];
                float2 delta = currentPos - prevPos;
                interpPositions[i] = prevPos + delta * t;

                if (compute != null && compute.idToIndex.TryGetValue(id, out int computeIndex))
                {
                    compute.positions[computeIndex] = interpPositions[i];
                    compute.scales[computeIndex] = scales[i];
                    compute.particleTypes[computeIndex] = solver.particleTypes[solverIndex];

                    float4 emission = solver.emissionColors[solverIndex];
                    compute.emissionColors[computeIndex] =
                        new Vector4(emission.x, emission.y, emission.z, emission.w);
                }
            }
        }

        base.OnPreComputeUpdate();
    }

    protected override void OnDestroy()
    {
        if (solver != null)
        {
            solver.OnAddParticles -= OnSolverAddParticles;
            solver.OnStartRemoveParticles -= OnSolverRemoveParticlesStart;
        }

        base.OnDestroy();
    }
}
