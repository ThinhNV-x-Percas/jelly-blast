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
			particle.transform.SetParent(base.transform, worldPositionStays: false);
			particles[i] = particle;
			global::UnityEngine.RectTransform rt = particle.rt;
			float anchorX = (i < count * 0.5f) ? 0f : 1f;
			rt.anchorMin = new global::UnityEngine.Vector2(anchorX, 0.5f);
			rt.anchorMax = new global::UnityEngine.Vector2(anchorX, 0.5f);
			rt.pivot = new global::UnityEngine.Vector2(0.5f, 0.5f);
			rt.anchoredPosition = global::UnityEngine.Vector2.zero;
			rt.localScale = global::UnityEngine.Vector3.one;
			float angleDeg = global::UnityEngine.Random.Range(-1f, 1f) * 15f;
			float angleRad = angleDeg * global::UnityEngine.Mathf.Deg2Rad;
			float dirSign = (anchorX == 0f) ? 1f : -1f;
			float speedScale = global::UnityEngine.Random.Range(0.5f, 1f);
			particle.velocity = new global::UnityEngine.Vector2(dirSign * speedScale * maxVel * global::UnityEngine.Mathf.Sin(angleRad), speedScale * maxVel * global::UnityEngine.Mathf.Cos(angleRad));
			particle.rotation = global::UnityEngine.Random.Range(0f, 360f);
			particle.angularVelocity = global::UnityEngine.Random.Range(-1f, 1f) * maxAngularVelocity;
			if (colors != null && colors.Length > 0)
			{
				global::UnityEngine.UI.Graphic graphic = particle.GetComponent<global::UnityEngine.UI.Graphic>();
				if (graphic != null)
				{
					graphic.color = colors[global::UnityEngine.Random.Range(0, colors.Length)];
				}
			}
			targetScales[i] = global::UnityEngine.Random.Range(0.2f, 1f);
			startTimes[i] = global::UnityEngine.Time.time + global::UnityEngine.Random.Range(0f, maxStartDelay);
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x600042B")]
	[global::Cpp2ILInjected.Address(RVA = "0x101D4B4", Offset = "0x101D4B4", Length = "0x304")]
	private void FixedUpdate()
	{
		CoinParticle[] array = particles;
		if (array == null)
		{
			return;
		}
		for (int i = 0; i < array.Length; i++)
		{
			CoinParticle particle = array[i];
			if (particle == null)
			{
				continue;
			}
			float t = global::UnityEngine.Mathf.Clamp01((global::UnityEngine.Time.time - startTimes[i]) / scaleDuration);
			float eased = EasingFunction.EaseInOutCubic(t);
			float scale = eased * targetScales[i];
			particle.rt.localScale = new global::UnityEngine.Vector3(scale, scale, scale);
			if (global::UnityEngine.Time.time > startTimes[i])
			{
				particle.acceleration = new global::UnityEngine.Vector2(0f, gravity);
				particle.UpdatePhysics();
				if (global::UnityEngine.Time.time > startTimes[i] + duration)
				{
					global::UnityEngine.Object.Destroy(particle.gameObject);
				}
			}
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x600042C")]
	[global::Cpp2ILInjected.Address(RVA = "0x101D7B8", Offset = "0x101D7B8", Length = "0x9C")]
	public ConfettiScreen()
	{
		count = 100;
		maxVel = 4000f;
		gravity = -100f;
		maxStartDelay = 0f;
	}
}
