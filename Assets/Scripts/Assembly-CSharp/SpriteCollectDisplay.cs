using System;
using System.Collections.Generic;
using UnityEngine;

public class SpriteCollectDisplay : MonoBehaviour
{
    public List<CollectSprite> sprites = new List<CollectSprite>();
    public float damping = 2f;
    public float maxStartSpeed;
    public float collectForce;
    public float minApplyForceDuration;
    public float maxApplyForceDuration;
    public float scaleUpDuration;
    public float spriteScale = 0.25f;
    public CollectSprite spritePrefab;

    private void FixedUpdate()
    {
        float deltaTime = Time.fixedDeltaTime;
        for (int i = sprites.Count - 1; i >= 0; i--)
        {
            CollectSprite sprite = sprites[i];
            if (sprite == null)
            {
                sprites.RemoveAt(i);
                continue;
            }

            sprite.prevPos = sprite.pos;
            if (Time.time < sprite.startTime)
            {
                continue;
            }

            sprite.targetPos = sprite.getTargetPos != null ? sprite.getTargetPos() : (Vector2)transform.position;

            float forceT = Mathf.Clamp01((Time.time - sprite.startTime) / sprite.applyForceDuration);
            Vector2 toTarget = sprite.targetPos - sprite.pos;
            sprite.vel += toTarget.normalized * (collectForce * forceT) * deltaTime;
            sprite.vel -= sprite.vel * damping * deltaTime;
            sprite.pos += sprite.vel * deltaTime;

            // Collected once the sprite has passed the target along the start -> target direction.
            if (Vector2.Dot(sprite.pos - sprite.targetPos, sprite.targetPos - sprite.startPos) > 0f)
            {
                RemoveSprite(sprite);
            }
        }
    }

    private void Update()
    {
        float interp = Mathf.Clamp01((Time.time - Time.fixedTime) / Time.fixedDeltaTime);
        foreach (CollectSprite sprite in sprites)
        {
            float z = transform.position.z;
            Transform spriteTransform = sprite.transform;

            if (Time.time < sprite.startTime)
            {
                spriteTransform.position = new Vector3(sprite.pos.x, sprite.pos.y, z);
                spriteTransform.localScale = Vector3.zero;
                continue;
            }

            Vector2 position = Vector2.Lerp(sprite.prevPos, sprite.pos, interp);
            spriteTransform.position = new Vector3(position.x, position.y, z);

            float progress = Mathf.Clamp01((Time.time - sprite.startTime) / scaleUpDuration);
            float scale = spriteScale;
            if (progress < 1f)
            {
                scale *= EasingFunction.EaseOutElastic(progress);
            }
            spriteTransform.localScale = Vector3.one * scale;
        }
    }

    public void AddSprite(Sprite sprite, Vector2 position, Vector2 vel, float delay, Func<Vector2> getTargetPos = null, Action onComplete = null)
    {
        CollectSprite collectSprite = Instantiate(spritePrefab, transform);
        collectSprite.transform.localScale = Vector3.zero;
        collectSprite.Init(sprite);
        collectSprite.pos = position;
        collectSprite.prevPos = position;
        collectSprite.transform.position = new Vector3(position.x, position.y, 0f);
        collectSprite.vel = vel;
        collectSprite.startPos = position;
        collectSprite.applyForceDuration = UnityEngine.Random.Range(minApplyForceDuration, maxApplyForceDuration);
        collectSprite.startTime = Time.time + delay;
        collectSprite.onComplete = onComplete;
        collectSprite.getTargetPos = getTargetPos;
        sprites.Add(collectSprite);
    }

    public void RemoveSprite(CollectSprite sprite)
    {
        sprite.onComplete?.Invoke();
        sprites.Remove(sprite);
        Destroy(sprite.gameObject);
    }
}
