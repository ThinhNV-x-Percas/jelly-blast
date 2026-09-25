[global::Cpp2ILInjected.Token(Token = "0x20000E7")]
public class ConfettiScreen : Viewport
{
	[global::Cpp2ILInjected.Token(Token = "0x40004CA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public CoinParticle particlePrefab;

	[global::Cpp2ILInjected.Token(Token = "0x40004CB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public int count;

	[global::Cpp2ILInjected.Token(Token = "0x40004CC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
	public float maxVel;

	[global::Cpp2ILInjected.Token(Token = "0x40004CD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public float gravity;

	[global::Cpp2ILInjected.Token(Token = "0x40004CE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public CoinParticle[] particles;

	[global::Cpp2ILInjected.Token(Token = "0x40004CF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	private float[] startTimes;

	[global::Cpp2ILInjected.Token(Token = "0x40004D0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	private float[] targetScales;

	[global::Cpp2ILInjected.Token(Token = "0x40004D1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public float maxStartDelay;

	[global::Cpp2ILInjected.Token(Token = "0x40004D2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x8C")]
	public float scaleDuration;

	[global::Cpp2ILInjected.Token(Token = "0x40004D3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public float duration;

	[global::Cpp2ILInjected.Token(Token = "0x40004D4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x94")]
	public float maxAngularVelocity;

	[global::Cpp2ILInjected.Token(Token = "0x40004D5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public global::UnityEngine.Color[] colors;

	[global::Cpp2ILInjected.Token(Token = "0x6000429")]
	[global::Cpp2ILInjected.Address(RVA = "0x101D388", Offset = "0x101D388", Length = "0x88")]
	protected internal override void OnStartShow()
	{
		base.OnStartShow();
		StartCoroutine(HandleStartShow());
	}

	[global::Cpp2ILInjected.Token(Token = "0x600042A")]
	[global::Cpp2ILInjected.Address(RVA = "0x101D410", Offset = "0x101D410", Length = "0x78")]
	private global::System.Collections.IEnumerator HandleStartShow()
	{
		yield return new global::UnityEngine.WaitForSeconds(0.1f);
		particles = new CoinParticle[count];
		startTimes = new float[count];
		targetScales = new float[count];
		for (int i = 0; i < count; i++)
		{
			CoinParticle particle = global::UnityEngine.Object.Instantiate(particlePrefab);
			particle.transform.SetParent(base.transform, false);
			float anchorX = count * 0.5f > i ? 1f : 0f;
			particle.rt.anchorMin = new global::UnityEngine.Vector2(anchorX, 0.5f);
			particle.rt.anchorMax = new global::UnityEngine.Vector2(anchorX, 0.5f);
			particle.rt.pivot = new global::UnityEngine.Vector2(0.5f, 0.5f);
			particle.rt.anchoredPosition = global::UnityEngine.Vector2.zero;
			particle.rt.localScale = global::UnityEngine.Vector3.zero;
			float angle = global::UnityEngine.Random.Range(-1f, 1f) * global::UnityEngine.Mathf.Deg2Rad * 15f;
			float speed = global::UnityEngine.Random.Range(0.5f, 1f) * maxVel;
			particle.velocity = new global::UnityEngine.Vector2(speed * global::UnityEngine.Mathf.Sin(angle), speed * global::UnityEngine.Mathf.Cos(angle));
			particle.rotation = global::UnityEngine.Random.Range(0f, 360f);
			particle.angularVelocity = global::UnityEngine.Random.Range(-1f, 1f) * maxAngularVelocity;
			particle.GetComponent<global::UnityEngine.UI.Image>().color = colors[global::UnityEngine.Random.Range(0, colors.Length)];
			if ((particle.velocity.x < 0f ? -1f : 1f) != (anchorX == 0f ? 1f : -1f))
				particle.velocity.x = -particle.velocity.x;
			particles[i] = particle;
			startTimes[i] = global::UnityEngine.Time.time + global::UnityEngine.Random.Range(0f, maxStartDelay);
			targetScales[i] = global::UnityEngine.Random.Range(0.2f, 1f);
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x600042B")]
	[global::Cpp2ILInjected.Address(RVA = "0x101D4B4", Offset = "0x101D4B4", Length = "0x304")]
	private void FixedUpdate()
	{
		if (particles == null)
			return;
		for (int i = 0; i < particles.Length; i++)
		{
			CoinParticle particle = particles[i];
			if (!particle)
				continue;
			particle.rt.localScale = global::UnityEngine.Vector3.one * (EasingFunction.EaseInOutCubic(global::UnityEngine.Mathf.Clamp01((global::UnityEngine.Time.time - startTimes[i]) / scaleDuration)) * targetScales[i]);
			if (global::UnityEngine.Time.time <= startTimes[i])
				continue;
			particle.acceleration = global::UnityEngine.Vector2.up * gravity;
			particle.UpdatePhysics();
			if (global::UnityEngine.Time.time > startTimes[i] + duration)
				global::UnityEngine.Object.Destroy(particle.gameObject);
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x600042C")]
	[global::Cpp2ILInjected.Address(RVA = "0x101D7B8", Offset = "0x101D7B8", Length = "0x9C")]
	public ConfettiScreen()
	{
		count = 100;
		maxVel = 4000f;
		gravity = -100f;
		maxStartDelay = 0.3f;
		scaleDuration = 1f;
		duration = 4f;
		maxAngularVelocity = 100f;
	}
}
