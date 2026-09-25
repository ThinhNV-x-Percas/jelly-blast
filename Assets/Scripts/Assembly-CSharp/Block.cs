using System.Collections.Generic;
using DG.Tweening;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public abstract class Block : MonoBehaviour
{
    protected internal FluidSolver solver;
    protected Transform visual;

    public bool isCleared;
    public List<Rigidbody> fragments;
    public ParticleSystem dust;
    public AudioClip shatterClip;

    public virtual void OnEnable()
    {
        solver = Singleton<GameManager>.Instance.solver;
        visual = GetComponent<InterpolateChild>().visual;
        solver.OnStartRemoveParticles += CheckClear;
    }

    public virtual void OnDisable()
    {
        if (!Application.isPlaying)
        {
            return;
        }

        solver.OnStartRemoveParticles -= CheckClear;
    }

    protected virtual void CheckClear(HashSet<int> particleIds, bool explode)
    {
        if (particleIds == null)
        {
            return;
        }

        foreach (int particleId in particleIds)
        {
            if (!solver.idToIndex.TryGetValue(particleId, out int index))
            {
                continue;
            }

            float2 particlePos = solver.positions[index];
            Vector3 position = transform.position;
            float dx = position.x - particlePos.x;
            float dy = position.y - particlePos.y;
            if (Mathf.Sqrt(dx * dx + dy * dy) < 0.5f)
            {
                ShatterDestroy();
                return;
            }
        }
    }

    protected internal void ShatterDestroy()
    {
        Instantiate(dust, transform.position, Quaternion.identity);
        isCleared = true;

        Collider2D blockCollider = GetComponent<Collider2D>();
        if (blockCollider != null)
        {
            blockCollider.enabled = false;
        }

        OnClear();

        for (int i = 0; i < fragments.Count; i++)
        {
            Rigidbody fragment = fragments[i];
            fragment.gameObject.SetActive(true);
            fragment.transform.parent = null;
            fragment.AddExplosionForce(300f, transform.position, 1f, 0.2f);
            fragment.maxAngularVelocity = 1000f;
            fragment.AddTorque(Random.onUnitSphere * Random.Range(-10, 10), ForceMode.Impulse);
            fragment.transform.DOScale(0f, 1f)
                .SetDelay(i * 0.02f)
                .OnComplete(() => Destroy(fragment.gameObject));
        }

        Renderer visualRenderer = visual.GetComponent<Renderer>();
        if (visualRenderer != null)
        {
            visualRenderer.enabled = false;
        }

        Singleton<GameManager>.Instance.coupler.RefreshBodies();
        Singleton<AudioManager>.Instance.PlayClip(shatterClip, new AudioClipSettings { pitchVariance = 0.2f, volume = 0.1f });
        Singleton<GameManager>.Instance.level.blocks.Remove(this);
        Destroy(gameObject);
    }

    public void OnPowerUpHit()
    {
        ShatterDestroy();
    }

    public abstract void OnClear();
}
