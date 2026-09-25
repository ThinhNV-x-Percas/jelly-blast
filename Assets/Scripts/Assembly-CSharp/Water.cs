using UnityEngine;

public class Water : SpecialFluid
{
    public override void OnPreComputeUpdate()
    {
        base.OnPreComputeUpdate();
        Vector3 position = transform.position;
        transform.position = new Vector3(position.x, position.y, -9f);
    }
}
