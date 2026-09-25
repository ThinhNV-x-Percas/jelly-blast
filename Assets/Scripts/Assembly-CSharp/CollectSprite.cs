using System;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class CollectSprite : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    public Vector2 pos;
    public Vector2 prevPos;
    public Vector2 vel;
    public float startTime;
    public float applyForceDuration;
    public Vector2 targetPos;
    public Vector2 startPos;
    public Action onComplete;
    public Func<Vector2> getTargetPos;

    public void Init(Sprite sprite)
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = sprite;
    }
}
