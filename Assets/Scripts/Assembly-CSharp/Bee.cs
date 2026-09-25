using System.Collections.Generic;
using UnityEngine;

public class Bee : RotatingSpecialFluid
{
    public void Init(FluidSolver _solver, HashSet<int> _particleIds, int _fluidType, FluidCompute _compute, int _id)
    {
        id = _id;
        base.Init(_solver, _particleIds, _fluidType, _compute);
    }

    public override void OnPreComputeUpdate()
    {
        base.OnPreComputeUpdate();
        Vector3 pos = transform.position;
        transform.position = new Vector3(pos.x, pos.y, id * depthStride - 6.25f);
    }
}
