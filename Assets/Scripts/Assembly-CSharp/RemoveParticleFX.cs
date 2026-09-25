using System.Collections.Generic;
using UnityEngine;

public class RemoveParticleFX : MonoBehaviour
{
    private FluidSolver solver;

    public ParticleSystem cloudParticles;
    public ParticleSystem sparkleParticles;
    public GameObject[] powerUpExplosionPrefabs;

    private void Awake()
    {
        solver = GetComponentInParent<FluidSolver>();
    }

    private void Start()
    {
        solver.OnStartRemoveParticles += OnRemoveParticles;
        solver.OnDetonatePowerUp += OnDetonatePowerUp;
    }

    private void OnDestroy()
    {
        if (solver != null)
        {
            solver.OnStartRemoveParticles -= OnRemoveParticles;
            solver.OnDetonatePowerUp -= OnDetonatePowerUp;
        }
    }

    public void OnRemoveParticles(HashSet<int> ids, bool explode)
    {
        if (ids == null)
        {
            return;
        }
        foreach (int particleId in ids)
        {
            if (!solver.idToIndex.TryGetValue(particleId, out int index))
            {
                continue;
            }
            // Power-up particles get their own explosion in OnDetonatePowerUp.
            if (solver.powerUpIds[index] != -1)
            {
                continue;
            }

            Vector2 particlePos = solver.positions[index];
            transform.position = (Vector3)particlePos + Vector3.back * 5f;

            Color[] colors = Singleton<GameManager>.Instance.level.colors;
            Color particleColor = colors[solver.particleTypes[index] % colors.Length];

            if (cloudParticles != null)
            {
                ParticleSystem.MainModule cloudMain = cloudParticles.main;
                cloudMain.startColor = particleColor;
                cloudParticles.Emit(1);
            }

            if (sparkleParticles != null && Random.value < 0.1f)
            {
                ParticleSystem.MainModule sparkleMain = sparkleParticles.main;
                sparkleMain.startColor = particleColor;
                sparkleParticles.Emit(1);
            }
        }
    }

    public void OnDetonatePowerUp(PowerUp powerUp)
    {
        int mergeIndex = powerUp.mergeIndex;
        if (mergeIndex >= powerUpExplosionPrefabs.Length || powerUpExplosionPrefabs[mergeIndex] == null)
        {
            return;
        }
        GameObject explosion = Instantiate(powerUpExplosionPrefabs[mergeIndex]);
        explosion.transform.position = (Vector3)powerUp.position + Vector3.back * 4f;
        Destroy(explosion, 1f);
    }
}
