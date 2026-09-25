using System;
using UnityEngine;

public struct CollectParticleData
{
    public CollectParticleMode mode;
    public Vector2 prevPos;
    public Vector2 vel;
    public float startTime;
    public float applyForceDuration;
    public Vector2 targetPos;
    public Vector2 startPos;
    public float innerRadius;
    public float explodeDuration;
    public int particleId;
    public Action onComplete;
    public Func<Vector2> getTargetPos;
}
