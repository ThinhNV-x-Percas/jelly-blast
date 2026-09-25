using System.Collections;
using UnityEngine;

[global::Cpp2ILInjected.Token(Token = "0x20000CE")]
public class CoinsScreen : Viewport
{
	public global::TMPro.TextMeshProUGUI coinCountText;

	public ElasticScale coinCountElasticScale;

	public CoinParticle coinParticlePrefab;

	public int maxCoinParticleCount;

	public float coinParticleRadius;

	public float maxCoinParticleVelocity;

	private CoinParticle[] coinParticles;

	public float coinParticleCollectionRadius;

	public float coinParticleForce;

	public float maxStartDelay;

	public float minStartCollectionDelay;

	public float maxStartCollectionDelay;

	public float scaleDuration;

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
			return;
		particleCount = count < 5 ? 5 : Mathf.Min(count, maxCoinParticleCount);
		Singleton<AudioManager>.Instance?.PlayClip("coin drop", new AudioClipSettings { pitch = 1.25f });
		coinParticles = new CoinParticle[particleCount];
		collectionStartTimes = new float[particleCount];
		startTimes = new float[particleCount];
		for (int i = 0; i < particleCount; i++)
		{
			CoinParticle particle = Object.Instantiate(coinParticlePrefab);
			particle.transform.SetParent(base.transform, false);
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
		Vector3 target = base.transform.InverseTransformPoint(coinCountText.rectTransform.position);
		for (int i = 0; i < particleCount; i++)
		{
			CoinParticle particle = coinParticles[i];
			if (!particle)
				continue;
			particle.rt.localScale = Vector3.one * EasingFunction.EaseInOutCubic(Mathf.Clamp01((Time.time - startTimes[i]) / scaleDuration));
			if (Time.time <= startTimes[i])
				continue;
			if (Time.time > collectionStartTimes[i])
				particle.acceleration += ((Vector2)target - particle.rt.anchoredPosition).normalized * coinParticleForce;
			particle.UpdatePhysics();
			if (particle.position.y <= target.y)
				continue;
			Object.Destroy(particle.gameObject);
			particlesCollected++;
			displayedCoinCount = (int)(ApplicationManager.appData.playerData.coinCount - coinsCollected + (float)coinsCollected * particlesCollected / particleCount);
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

	public CoinsScreen()
	{
		maxCoinParticleCount = 40;
		coinParticleRadius = 90f;
		maxCoinParticleVelocity = 90f;
		coinParticleCollectionRadius = 90f;
		coinParticleForce = 90f;
		maxStartDelay = 0.5f;
		minStartCollectionDelay = 0.2f;
		maxStartCollectionDelay = 0.4f;
		scaleDuration = 0.4f;
	}
}
