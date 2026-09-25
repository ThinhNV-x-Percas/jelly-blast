using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ConfettiScreen : Viewport
{
    public CoinParticle particlePrefab;
    public int count = 100;
    public float maxVel = 4000f;
    public float gravity = -100f;
    public CoinParticle[] particles;

    private float[] startTimes;
    private float[] targetScales;

    public float maxStartDelay = 0.3f;
    public float scaleDuration = 1f;
    public float duration = 4f;
    public float maxAngularVelocity = 100f;
    public Color[] colors;

    protected internal override void OnStartShow()
    {
        base.OnStartShow();
        StartCoroutine(HandleStartShow());
    }

    private IEnumerator HandleStartShow()
    {
        yield return new WaitForSeconds(0.1f);

        particles = new CoinParticle[count];
        startTimes = new float[count];
        targetScales = new float[count];

        for (int i = 0; i < count; i++)
        {
            CoinParticle particle = Instantiate(particlePrefab);
            particle.transform.SetParent(transform, false);

            // First half spawns from the right edge, second half from the left.
            float anchorX = count * 0.5f > i ? 1f : 0f;
            particle.rt.anchorMin = new Vector2(anchorX, 0.5f);
            particle.rt.anchorMax = new Vector2(anchorX, 0.5f);
            particle.rt.pivot = new Vector2(0.5f, 0.5f);
            particle.rt.anchoredPosition = Vector2.zero;
            particle.rt.localScale = Vector3.zero;

            float angle = Random.Range(-1f, 1f) * Mathf.Deg2Rad * 15f;
            float speed = Random.Range(0.5f, 1f) * maxVel;
            particle.velocity = new Vector2(speed * Mathf.Sin(angle), speed * Mathf.Cos(angle));
            particle.rotation = Random.Range(0f, 360f);
            particle.angularVelocity = Random.Range(-1f, 1f) * maxAngularVelocity;
            particle.GetComponent<Image>().color = colors[Random.Range(0, colors.Length)];

            float velocitySign = particle.velocity.x < 0f ? -1f : 1f;
            float inwardSign = anchorX == 0f ? 1f : -1f;
            if (velocitySign != inwardSign)
            {
                particle.velocity.x = -particle.velocity.x;
            }

            particles[i] = particle;
            startTimes[i] = Time.time + Random.Range(0f, maxStartDelay);
            targetScales[i] = Random.Range(0.2f, 1f);
        }
    }

    private void FixedUpdate()
    {
        if (particles == null)
        {
            return;
        }

        for (int i = 0; i < particles.Length; i++)
        {
            CoinParticle particle = particles[i];
            if (particle == null)
            {
                continue;
            }

            float scaleT = Mathf.Clamp01((Time.time - startTimes[i]) / scaleDuration);
            particle.rt.localScale = Vector3.one * EasingFunction.EaseInOutCubic(scaleT) * targetScales[i];

            if (Time.time <= startTimes[i])
            {
                continue;
            }

            particle.acceleration = Vector2.up * gravity;
            particle.UpdatePhysics();

            if (Time.time > startTimes[i] + duration)
            {
                Destroy(particle.gameObject);
            }
        }
    }
}
