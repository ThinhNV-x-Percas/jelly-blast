using System;
using UnityEngine;

public class FluidCollectDisplay : FluidRendererBase
{
    private const float ShrinkDuration = 0.2f;
    private const float FlashDuration = 0.1f;

    public float particleSize = 0.2f;

    private CollectParticleData[] particles;

    public float damping = 2f;
    public float maxStartSpeed;
    public float collectForce;
    public float minApplyForceDuration;
    public float maxApplyForceDuration = 1f;
    public float explodeDuration = 0.4f;
    public AnimationCurve scaleAnimationCurve;
    public AnimationCurve innerRadiusAnimationCurve;
    public float minExplodeDuration = 1f;
    public float maxExplodeDuration = 2f;
    public int fluidType = -1;

    protected MaterialPropertyBlock _propBlock;

    public override void Init()
    {
        particles = new CollectParticleData[maxParticles];
        SetFluidType(fluidType);
        base.Init();
    }

    public void SetFluidType(int value)
    {
        fluidType = value;
        if (value == -1)
        {
            return;
        }

        _propBlock = new MaterialPropertyBlock();
        mr.GetPropertyBlock(_propBlock);
        _propBlock.SetInt("_FluidType", fluidType);
        mr.SetPropertyBlock(_propBlock);
    }

    private void FixedUpdate()
    {
        float deltaTime = Time.fixedDeltaTime;
        for (int i = activeCount - 1; i >= 0; i--)
        {
            if (particles[i].mode == CollectParticleMode.Shrink)
            {
                continue;
            }

            particles[i].prevPos = positions[i];

            Vector2 force = Vector2.zero;
            if (particles[i].mode == CollectParticleMode.Collect)
            {
                if (particles[i].getTargetPos != null)
                {
                    particles[i].targetPos = particles[i].getTargetPos();
                }

                float forceT = Mathf.Clamp01((Time.time - particles[i].startTime) / particles[i].applyForceDuration);
                Vector2 toTarget = particles[i].targetPos - positions[i];
                force = toTarget.normalized * (collectForce * forceT);
            }

            particles[i].vel += force * deltaTime;
            particles[i].vel -= particles[i].vel * damping * deltaTime;
            positions[i] += particles[i].vel * deltaTime;

            if (particles[i].mode != CollectParticleMode.Collect)
            {
                continue;
            }

            // Collected once the particle has passed the target along the start -> target direction.
            Vector2 fromTarget = positions[i] - particles[i].targetPos;
            Vector2 startToTarget = particles[i].targetPos - particles[i].startPos;
            if (Vector2.Dot(fromTarget, startToTarget) > 0f)
            {
                RemoveParticle(i);
            }
        }
    }

    public override void OnPreComputeUpdate()
    {
        float time = Time.time;
        float interp = Mathf.Clamp01((time - Time.fixedTime) / Time.fixedDeltaTime);

        for (int i = activeCount - 1; i >= 0; i--)
        {
            ref CollectParticleData particle = ref particles[i];

            if (particle.mode == CollectParticleMode.Shrink)
            {
                if (time >= particle.startTime + ShrinkDuration)
                {
                    RemoveParticle(i);
                    continue;
                }

                if (particle.getTargetPos != null)
                {
                    particle.targetPos = particle.getTargetPos();
                }

                float shrinkT = (time - particle.startTime) / ShrinkDuration;
                shrinkT *= shrinkT;
                interpPositions[i] = Vector2.Lerp(particle.startPos, particle.targetPos, shrinkT);
                scales[i] = (1f - shrinkT * 0.1f) * particleSize;
            }
            else
            {
                if (particle.mode == CollectParticleMode.Explode)
                {
                    if (time >= particle.startTime + particle.explodeDuration)
                    {
                        RemoveParticle(i);
                        continue;
                    }

                    float explodeT = (time - particle.startTime) / particle.explodeDuration;
                    scales[i] = scaleAnimationCurve.Evaluate(explodeT) * particleSize;
                    particle.innerRadius = innerRadiusAnimationCurve.Evaluate(explodeT);
                }

                interpPositions[i] = particle.prevPos + (positions[i] - particle.prevPos) * interp;
            }

            if (!compute.idToIndex.TryGetValue(particle.particleId, out int computeIndex))
            {
                continue;
            }

            compute.positions[computeIndex] = interpPositions[i];
            compute.innerRadii[computeIndex] = particle.innerRadius;
            compute.scales[computeIndex] = scales[i];

            float flashAlpha = Mathf.Clamp01(1f - (time - particle.startTime) / FlashDuration);
            compute.emissionColors[computeIndex] = new Vector4(1f, 0f, 0f, flashAlpha);
        }

        base.OnPreComputeUpdate();
    }

    public void AddCollectParticle(Vector2 position, Vector2 vel, int type, Func<Vector2> getTargetPos, Action onComplete = null)
    {
        if (activeCount < maxParticles)
        {
            AddParticle(position, vel, type, CollectParticleMode.Collect, 0f, getTargetPos, onComplete);
        }
    }

    public void AddExplodeParticle(Vector2 position, Vector2 vel, int type)
    {
        if (activeCount < maxParticles)
        {
            AddParticle(position, vel, type, CollectParticleMode.Explode, UnityEngine.Random.Range(minExplodeDuration, maxExplodeDuration));
        }
    }

    public void AddShrinkParticle(Vector2 position, Vector2 vel, int type, Func<Vector2> getTargetPos)
    {
        if (activeCount < maxParticles)
        {
            AddParticle(position, vel, type, CollectParticleMode.Shrink, 0f, getTargetPos);
        }
    }

    public CollectParticleData AddParticle(Vector2 position, Vector2 vel, int type, CollectParticleMode mode, float explodeDuration = 1f, Func<Vector2> getTargetPos = null, Action onComplete = null)
    {
        positions[activeCount] = position;
        interpPositions[activeCount] = position;
        scales[activeCount] = particleSize;

        float applyForceDuration = UnityEngine.Random.Range(minApplyForceDuration, maxApplyForceDuration);
        float time = Time.time;
        int id = IdGenerator.Next();
        compute.AddParticle(id, ctx =>
        {
            compute.particleTypes[ctx.Index] = type;
            compute.isRounded[ctx.Index] = 0f;
        });

        CollectParticleData particle = new CollectParticleData
        {
            mode = mode,
            prevPos = position,
            vel = vel,
            startTime = time,
            applyForceDuration = applyForceDuration,
            targetPos = position,
            startPos = position,
            innerRadius = 0f,
            explodeDuration = explodeDuration,
            particleId = id,
            onComplete = onComplete,
            getTargetPos = getTargetPos
        };
        particles[activeCount] = particle;
        activeCount++;
        return particle;
    }

    public void RemoveParticle(int index)
    {
        if (index < 0 || index >= activeCount)
        {
            return;
        }

        particles[index].onComplete?.Invoke();
        compute.RemoveParticle(particles[index].particleId);

        int lastIndex = activeCount - 1;
        if (lastIndex != index)
        {
            particles[index] = particles[lastIndex];
            positions[index] = positions[lastIndex];
            scales[index] = scales[lastIndex];
        }
        activeCount = lastIndex;
    }
}
