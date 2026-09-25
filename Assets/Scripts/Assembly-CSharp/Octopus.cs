using System.Collections.Generic;
using System.Linq;
using Unity.Mathematics;
using UnityEngine;

public class Octopus : SpecialFluid
{
    public HashSet<int> headParticleIds = new HashSet<int>();

    public int splitIndex;

    public void Init(FluidSolver _solver, HashSet<int> _particleIds, int _fluidType, FluidCompute _compute, int _id, HashSet<int> _headIds, int _splitIndex)
    {
        id = _id;
        headParticleIds = _headIds;
        splitIndex = _splitIndex;
        base.Init(_solver, _particleIds, _fluidType, _compute);
    }

    public override void OnPreComputeUpdate()
    {
        base.OnPreComputeUpdate();

        mr.GetPropertyBlock(_propBlock);
        if (solver.octopusHeadMidpoints.TryGetValue(id, out float2 headMidpoint))
            _propBlock.SetVector("_HeadPosition", new Vector4(headMidpoint.x, headMidpoint.y, 0f, 0f));
        mr.SetPropertyBlock(_propBlock);

        Vector3 pos = transform.position;
        transform.position = new Vector3(pos.x, pos.y, id * depthStride - 1f);
    }

    public void Split()
    {
        if (solver == null || particleIds == null)
            return;

        int count = particleIds.Count;

        float2 mean = float2.zero;
        foreach (int particleId in particleIds)
        {
            if (solver.idToIndex.TryGetValue(particleId, out int index))
                mean += solver.positions[index];
        }
        mean /= count;

        float sxx = 0f;
        float sxy = 0f;
        float syy = 0f;
        foreach (int particleId in particleIds)
        {
            if (!solver.idToIndex.TryGetValue(particleId, out int index))
                continue;

            float2 d = solver.positions[index] - mean;
            sxx += d.x * d.x;
            sxy += d.x * d.y;
            syy += d.y * d.y;
        }
        sxx /= count;
        sxy /= count;
        syy /= count;

        // Principal axis of the particle cloud; the octopus is cut perpendicular to it.
        float2 axis;
        if (Mathf.Abs(sxy) > 1E-06f)
        {
            float trace = sxx + syy;
            float det = sxx * syy - sxy * sxy;
            float lambda = trace * 0.5f + Mathf.Sqrt(trace * trace * 0.25f - det);
            axis = new float2(lambda - syy, sxy);
        }
        else
        {
            axis = sxx >= syy ? new float2(1f, 0f) : new float2(0f, 1f);
        }
        axis *= 1f / Mathf.Sqrt(axis.x * axis.x + axis.y * axis.y);

        List<int> sorted = particleIds
            .OrderBy(particleId => solver.idToIndex.TryGetValue(particleId, out int index)
                ? math.dot(solver.positions[index] - mean, axis)
                : 0f)
            .ToList();

        int half = (count + 1) >> 1;
        AddOctopus(sorted.GetRange(0, half));
        AddOctopus(sorted.GetRange(half, sorted.Count - half));
        solver.RemoveOctopus(this);
    }

    private void AddOctopus(List<int> ids)
    {
        float2[] positionsToAdd = new float2[ids.Count];
        for (int i = 0; i < ids.Count; i++)
        {
            if (solver.idToIndex.TryGetValue(ids[i], out int index))
                positionsToAdd[i] = solver.positions[index];
        }

        Octopus octopus = solver.AddOctopus(positionsToAdd, splitIndex - 1);
        if (octopus != null)
            octopus.StartCoroutine(octopus.HandlePopIn());
    }
}
