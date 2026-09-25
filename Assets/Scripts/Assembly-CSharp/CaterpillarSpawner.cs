using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class CaterpillarSpawner : MonoBehaviour
{
    private int particleCount = 7;

    public float spawnRadius = 3f;

    private void Awake()
    {
        Singleton<GameManager>.Instance.OnInit += OnInit;
    }

    public void OnInit()
    {
        float2[] positions = new float2[particleCount];
        for (int i = 0; i < particleCount; i++)
        {
            Vector2 center = transform.position;
            Vector2 offset = Random.insideUnitCircle * spawnRadius * 0.5f;
            positions[i] = center + offset;
        }
        Singleton<GameManager>.Instance.solver.AddCaterpillar(positions);
    }
}
