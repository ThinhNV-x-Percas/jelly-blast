using System.Collections.Generic;
using UnityEngine;

public class Stone : Block
{
    private bool wasTouch;

    public override void OnEnable()
    {
        base.OnEnable();
        solver.OnRemoveRegionStart += RemoveRegionStarted;
        solver.OnRemoveRegionComplete += RemoveRegion;
    }

    public override void OnDisable()
    {
        base.OnDisable();
        solver.OnRemoveRegionStart -= RemoveRegionStarted;
        solver.OnRemoveRegionComplete -= RemoveRegion;
    }

    private void RemoveRegionStarted(bool createPowerUp, Vector2 worldPosition)
    {
        wasTouch = true;
    }

    private void RemoveRegion(HashSet<int> particleIds, int regionId)
    {
        wasTouch = false;
    }

    protected override void CheckClear(HashSet<int> particleIds, bool explode)
    {
        // Stones only break from particles removed by explosions, not by a direct tap.
        if (wasTouch)
        {
            return;
        }

        base.CheckClear(particleIds, explode);
    }

    public override void OnClear()
    {
        Vector3 position = transform.position;
        Vector2 velocity = GetComponent<Rigidbody2D>().velocity;
        Singleton<CollectionManager>.Instance.OnCollectStoneBlock(new Vector2(position.x, position.y), velocity);
    }
}
