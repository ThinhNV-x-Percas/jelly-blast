using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpongeSpawner : MonoBehaviour
{
    private int subSpongeParticleCount = 7;

    public float spawnRadius = 3f;

    private void Awake()
    {
        Singleton<GameManager>.Instance.OnInit += OnInit;
    }

    public void OnInit()
    {
        float2[] positions = new float2[subSpongeParticleCount];
        for (int i = 0; i < subSpongeParticleCount; i++)
        {
            Vector2 center = transform.position;
            Vector2 offset = Random.insideUnitCircle * spawnRadius * 0.5f;
            positions[i] = center + offset;
        }
        Singleton<GameManager>.Instance.solver.AddSponge(positions);
    }
}
