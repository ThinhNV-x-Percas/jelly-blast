using System.Runtime.CompilerServices;
using UnityEngine;

// 2D spiky kernels (Sebastian Lague style). Not referenced by the current job pipeline.
internal static class SPHKernels
{
    // The original values were loaded from a constant block that was not recovered.
    // r matches the neighbour-search cell size (particleRadius * 2 with the scene's 0.15).
    private const float SmoothingRadius = 0.3f;

    public static readonly float r = SmoothingRadius;

    private static readonly float densityCoef = 6f / (Mathf.PI * Mathf.Pow(SmoothingRadius, 4f));
    private static readonly float nearDensityCoef = 10f / (Mathf.PI * Mathf.Pow(SmoothingRadius, 5f));
    private static readonly float viscosityVolume = Mathf.PI * Mathf.Pow(SmoothingRadius, 3f) / 3f;

    public const float RHO_EPS = 1E-06f;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float DensityKernel(float dst)
    {
        if (dst >= r)
        {
            return 0f;
        }
        float v = r - dst;
        return densityCoef * v * v;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float NearDensityKernel(float dst)
    {
        if (dst >= r)
        {
            return 0f;
        }
        float v = r - dst;
        return nearDensityCoef * v * v * v;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float DensityDerivative(float dst)
    {
        if (dst > r)
        {
            return 0f;
        }
        return -(r - dst) * densityCoef;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float NearDensityDerivative(float dst)
    {
        if (dst > r)
        {
            return 0f;
        }
        float v = r - dst;
        return nearDensityCoef * -(v * v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float ViscosityKernel(float dst)
    {
        if (dst >= r)
        {
            return 0f;
        }
        return (r - dst) / viscosityVolume;
    }
}
