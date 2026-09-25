using System.Collections;
using TMPro;
using UnityEngine;

public class CoinsScreen : Viewport
{
    public TextMeshProUGUI coinCountText;
    public ElasticScale coinCountElasticScale;
    public CoinParticle coinParticlePrefab;
    public int maxCoinParticleCount = 40;
    public float coinParticleRadius = 90f;
    public float maxCoinParticleVelocity = 90f;

    private CoinParticle[] coinParticles;

    public float coinParticleCollectionRadius = 90f;
    public float coinParticleForce = 90f;
    public float maxStartDelay = 0.5f;
    public float minStartCollectionDelay = 0.2f;
    public float maxStartCollectionDelay = 0.4f;
    public float scaleDuration = 0.4f;

    private float[] startTimes;
    private float[] collectionStartTimes;

    public int coinsCollected;
    public int displayedCoinCount;

    private int particleCount;
    private int particlesCollected;

    protected internal override void OnStartShow()
    {
        displayedCoinCount = ApplicationManager.appData.playerData.coinCount - Singleton<GameManager>.Instance.coinsCollected;
        coinCountText.text = NumberFormatter.FormatNumber(displayedCoinCount);
        particlesCollected = 0;
        StartCoroutine(HandleStartShow());
    }

    private IEnumerator HandleStartShow()
    {
        coinCountElasticScale.gameObject.SetActive(false);
        yield return new WaitForSeconds(0.3f);
        coinCountElasticScale.gameObject.SetActive(true);
        coinCountElasticScale.SetScale(0f);
        coinCountElasticScale.Pop();
    }

    public void ShowCoinAnim(int count)
    {
        coinsCollected = count;
        if (count < 1)
        {
            return;
        }

        particleCount = count < 5 ? 5 : Mathf.Min(count, maxCoinParticleCount);
        Singleton<AudioManager>.Instance?.PlayClip("coin drop", new AudioClipSettings { pitch = 1.25f });

        coinParticles = new CoinParticle[particleCount];
        collectionStartTimes = new float[particleCount];
        startTimes = new float[particleCount];

        for (int i = 0; i < particleCount; i++)
        {
            CoinParticle particle = Instantiate(coinParticlePrefab);
            particle.transform.SetParent(transform, false);
            particle.rt.anchoredPosition = Vector2.zero;
            particle.rt.localScale = Vector3.zero;
            particle.rotation = Random.Range(0, 360);
            particle.velocity = Random.insideUnitCircle.normalized * Random.Range(0.75f, 1f) * maxCoinParticleVelocity;
            coinParticles[i] = particle;

            startTimes[i] = Time.time + Random.Range(0f, maxStartDelay);
            collectionStartTimes[i] = startTimes[i] + Random.Range(minStartCollectionDelay, maxStartCollectionDelay);
        }
    }

    private void FixedUpdate()
    {
        Vector3 target = transform.InverseTransformPoint(coinCountText.transform.position);
        for (int i = 0; i < particleCount; i++)
        {
            CoinParticle particle = coinParticles[i];
            if (particle == null)
            {
                continue;
            }

            float scaleT = Mathf.Clamp01((Time.time - startTimes[i]) / scaleDuration);
            particle.rt.localScale = Vector3.one * EasingFunction.EaseInOutCubic(scaleT);

            if (Time.time <= startTimes[i])
            {
                continue;
            }

            if (Time.time > collectionStartTimes[i])
            {
                Vector2 toTarget = (Vector2)target - particle.rt.anchoredPosition;
                particle.acceleration += toTarget.normalized * coinParticleForce;
            }

            particle.UpdatePhysics();
            if (particle.position.y <= target.y)
            {
                continue;
            }

            Destroy(particle.gameObject);
            particlesCollected++;

            int startCount = ApplicationManager.appData.playerData.coinCount - coinsCollected;
            displayedCoinCount = (int)(startCount + (float)coinsCollected * particlesCollected / particleCount);
            coinCountElasticScale.Pop();
            coinCountText.text = NumberFormatter.FormatNumber(displayedCoinCount);
            Singleton<AudioManager>.Instance?.PlayClip("coin collect", new AudioClipSettings { pitchVariance = 0.4f });
        }
    }

    public void UpdateDisplayedCoinCount(int count, bool pop = false)
    {
        if (pop)
        {
            coinCountElasticScale.Pop();
        }

        coinCountText.text = NumberFormatter.FormatNumber(count);
    }
}
