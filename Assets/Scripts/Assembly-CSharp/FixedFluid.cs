using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class FixedFluid : MonoBehaviour
{
    public enum SpecialFluidType
    {
        Default = 0,
        Mud = 1,
        Water = 2,
        Snow = 3
    }

    public SpecialFluidType type;
    public int colorIdx;
    public float width;
    public float height;
    public bool isHoneyCoated;

    private void Awake()
    {
        Singleton<GameManager>.Instance.OnInit += OnInit;
    }

    public void OnInit()
    {
        FluidSolver solver = Singleton<GameManager>.Instance.solver;

        float mass = Mathf.Max(solver.particleMass, 1E-06f);
        float particleCount = width * height * solver.targetDensity * (solver.nearPressureMultiplier * 0.25f) / mass;
        int count = Mathf.CeilToInt(particleCount);

        Vector3 center = transform.position;
        float2[] positions = new float2[count];
        for (int i = 0; i < count; i++)
        {
            float x = center.x + Random.Range(width * -0.5f, width * 0.5f);
            float y = center.y + Random.Range(height * -0.5f, height * 0.5f);
            positions[i] = new float2(x, y);
        }

        switch (type)
        {
            case SpecialFluidType.Default:
                solver.AddParticles(positions, colorIdx, ctx =>
                {
                    if (!isHoneyCoated)
                        return;

                    solver.isHoneyCoated[ctx.Index] = true;
                    Singleton<GameManager>.Instance.honeyTest.AddSolverParticle(ctx);
                });
                break;
            case SpecialFluidType.Water:
                solver.AddWaterParticles(positions);
                break;
            case SpecialFluidType.Snow:
                solver.AddSnow(positions);
                break;
            default:
                solver.AddMud(positions);
                break;
        }
    }

    private void OnDrawGizmos()
    {
        Level level = transform.parent != null ? transform.parent.GetComponent<Level>() : null;
        Color color = type == SpecialFluidType.Water || level == null || level.colors == null || colorIdx >= level.colors.Length
            ? new Color(0.5f, 0.5f, 0.5f)
            : level.colors[colorIdx];
        color.a = 0.5f;
        Gizmos.color = color;
        Gizmos.DrawCube(transform.position, new Vector3(width, height, 0f));
    }
}
