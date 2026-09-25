using System.Collections.Generic;
using UnityEngine;

public class Caterpillar : RotatingSpecialFluid
{
    public ParticleSystem dust;
    public Transform levelBottomTransform;

    public void Init(FluidSolver _solver, HashSet<int> _particleIds, int _fluidType, FluidCompute _compute, int _id)
    {
        id = _id;
        levelBottomTransform = Singleton<GameManager>.Instance.level.bottomTransform;
        base.Init(_solver, _particleIds, _fluidType, _compute);
    }

    public override void OnPreComputeUpdate()
    {
        base.OnPreComputeUpdate();

        Vector3 pos = transform.position;
        transform.position = new Vector3(pos.x, pos.y, id * depthStride - 6f);

        if (levelBottomTransform == null || min.y >= levelBottomTransform.position.y)
            return;

        Singleton<CollectionManager>.Instance.OnCollectCaterpillar(position);
        Instantiate(dust, transform.position + Vector3.back * 3f, Quaternion.identity);
        solver.RemoveCaterpillar(this);
    }
}
