using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class FluidSoundFX : MonoBehaviour
{
    [Header("Audio")]
    public AudioClip clip;

    // masterVolume, pitch, pitchVariance and minBrakingImpulse defaults came from an unrecovered
    // constant block; the scene overrides all of them.
    [Range(0f, 1f)]
    public float masterVolume = 1f;

    [Range(0f, 2f)]
    public float pitch = 1f;

    [Range(0f, 1f)]
    public float pitchVariance;

    [Header("Braking-impulse filter")]
    public float minBrakingImpulse;

    public float maxBrakingImpulse = 20f;

    [Range(0f, 1f)]
    public float smoothing = 0.5f;

    private FluidSolver solver;
    private float2[] smoothedVel;
    private float loudest;

    private void Awake()
    {
        Singleton<GameManager>.Instance.OnInit += OnInit;
    }

    private void OnDestroy()
    {
        GameManager gameManager = Singleton<GameManager>.Instance;
        if (gameManager != null)
        {
            gameManager.OnInit -= OnInit;
        }
        if (solver != null)
        {
            solver.OnStep -= OnFluidStep;
        }
    }

    private void OnInit()
    {
        solver = Singleton<GameManager>.Instance.solver;
        solver.OnStep += OnFluidStep;
        smoothedVel = new float2[solver.maxParticles];
    }

    private void OnFluidStep()
    {
        for (int i = 0; i < solver.maxParticles; i++)
        {
            if (Random.value < 0.25f)
            {
                continue;
            }
            if (solver.powerUpIds[i] != -1)
            {
                continue;
            }
            float2 previous = smoothedVel[i];
            float2 smoothed = previous + (solver.velocities[i] - previous) * smoothing;
            smoothedVel[i] = smoothed;
            float impulse = math.length(smoothed - previous);
            if (impulse < minBrakingImpulse)
            {
                continue;
            }
            float t = Mathf.Clamp01((impulse - minBrakingImpulse) / (maxBrakingImpulse - minBrakingImpulse));
            float volume = masterVolume * t;
            if (volume > loudest)
            {
                loudest = volume;
            }
        }
    }

    private void Update()
    {
        if (loudest <= 0f)
        {
            return;
        }
        AudioClipSettings settings = new AudioClipSettings
        {
            volume = loudest,
            pitch = pitch
        };
        Singleton<AudioManager>.Instance.PlayClip(clip, settings);
        loudest = 0f;
    }
}
