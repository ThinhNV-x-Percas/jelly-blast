using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpecialFluidSpawner : MonoBehaviour
{
    public enum SpecialFluidType
    {
        Mud = 0,
        Water = 1,
        Snow = 2
    }

    public SpecialFluidType type;

    public int particleCount = 30;

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

        FluidSolver solver = Singleton<GameManager>.Instance.solver;
        switch (type)
        {
            case SpecialFluidType.Mud:
                solver.AddMud(positions);
                break;
            case SpecialFluidType.Snow:
                solver.AddSnow(positions);
                break;
            case SpecialFluidType.Water:
                solver.AddWaterParticles(positions);
                break;
        }
    }
}
