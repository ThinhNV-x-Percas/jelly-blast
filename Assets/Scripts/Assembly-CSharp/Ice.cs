using UnityEngine;

public class Ice : Block
{
    public override void OnClear()
    {
        Vector3 position = transform.position;
        Vector2 velocity = GetComponent<Rigidbody2D>().velocity;
        Singleton<CollectionManager>.Instance.OnCollectIceBlock(new Vector2(position.x, position.y), velocity);
    }
}
