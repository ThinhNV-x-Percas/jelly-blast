using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class OctopusSpawner : MonoBehaviour
{
    [Range(1f, 4f)]
    public int tier = 4;

    private int baseParticleCount = 5;

    public float spawnRadius = 3f;

    private void Awake()
    {
        Singleton<GameManager>.Instance.OnInit += OnInit;
    }

    public void OnInit()
    {
        // Each split halves the octopus and lowers its tier by one, so a tier-0 piece ends up
        // with baseParticleCount particles.
        int count = (int)Mathf.Pow(2f, tier) * baseParticleCount;
        float2[] positions = new float2[count];
        for (int i = 0; i < count; i++)
        {
            Vector2 center = transform.position;
            Vector2 offset = Random.insideUnitCircle * spawnRadius * 0.5f;
            positions[i] = center + offset;
        }
        Singleton<GameManager>.Instance.solver.AddOctopus(positions, tier);
    }
}
