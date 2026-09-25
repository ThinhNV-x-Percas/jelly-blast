using UnityEngine;

public class Mud : SpecialFluid
{
    public override void OnPreComputeUpdate()
    {
        base.OnPreComputeUpdate();
        Vector3 position = transform.position;
        transform.position = new Vector3(position.x, position.y, id * depthStride - 1f);
    }
}
