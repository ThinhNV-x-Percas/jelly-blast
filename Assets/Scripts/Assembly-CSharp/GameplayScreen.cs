[global::Cpp2ILInjected.Token(Token = "0x20000EB")]
public class GameplayScreen : Viewport
{
	[global::Cpp2ILInjected.Token(Token = "0x40004DD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public GoalUI goalPrefab;

	[global::Cpp2ILInjected.Token(Token = "0x40004DE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public global::UnityEngine.RectTransform goalParent;

	[global::Cpp2ILInjected.Token(Token = "0x40004DF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public GoalUI[] goals;

	[global::Cpp2ILInjected.Token(Token = "0x40004E0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public global::TMPro.TextMeshProUGUI moveCounter;

	[global::Cpp2ILInjected.Token(Token = "0x40004E1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public UIButton settingsButton;

	[global::Cpp2ILInjected.Token(Token = "0x40004E2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public global::UnityEngine.GameObject moveEffectPrefab;

	[global::Cpp2ILInjected.Token(Token = "0x40004E3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public global::UnityEngine.RectTransform moveEffectParent;

	[global::Cpp2ILInjected.Token(Token = "0x40004E4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	private global::UnityEngine.Coroutine pulseCoroutine;

	[global::Cpp2ILInjected.Token(Token = "0x40004E5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public UIIconGenerator iconGenerator;

	[global::Cpp2ILInjected.Token(Token = "0x40004E6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public ElasticScale moveCountElasticScale;

	[global::Cpp2ILInjected.Token(Token = "0x40004E7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	private bool isPulsing;

	[global::Cpp2ILInjected.Token(Token = "0x600043C")]
	[global::Cpp2ILInjected.Address(RVA = "0x101E1A4", Offset = "0x101E1A4", Length = "0x12C")]
	protected internal override void Awake()
	{
		base.Awake();
		Singleton<GameManager>.Instance.OnInit += OnInit;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600043D")]
	[global::Cpp2ILInjected.Address(RVA = "0x101E2D0", Offset = "0x101E2D0", Length = "0x3D8")]
	private void OnInit()
	{
		int count = Singleton<GameManager>.Instance.level.goals.Count;
		goals = new GoalUI[count];
		for (int i = 0; i < count; i++)
		{
			GoalUI instance = global::UnityEngine.Object.Instantiate(goalPrefab);
			instance.transform.SetParent(goalParent.transform, worldPositionStays: false);
			instance.Init(i);
			goals[i] = instance;
		}
		settingsButton.m_OnClick.AddListener(OnSettingsButtonClicked);
		Singleton<GameManager>.Instance.OnUserMove += OnUserMove;
		UpdateMoveCounter();
	}

	[global::Cpp2ILInjected.Token(Token = "0x600043E")]
	[global::Cpp2ILInjected.Address(RVA = "0x101E780", Offset = "0x101E780", Length = "0xAC")]
	public global::UnityEngine.Vector2 GetWorldGoalPosition(int index)
	{
		global::UnityEngine.RectTransform rt = goals[index].GetComponent<global::UnityEngine.RectTransform>();
		return global::UnityEngine.Camera.main.ScreenToWorldPoint(rt.position);
	}

	[global::Cpp2ILInjected.Token(Token = "0x600043F")]
	[global::Cpp2ILInjected.Address(RVA = "0x101E82C", Offset = "0x101E82C", Length = "0x2CC")]
	private void OnUserMove()
	{
		int moveCount = Singleton<GameManager>.Instance.level.moveCount;
		moveCounter.text = moveCount.ToString();
		moveCountElasticScale.Pop();
		if (moveCount > 5)
		{
			moveCounter.color = global::UnityEngine.Color.white;
			if (isPulsing)
			{
				StopCoroutine(pulseCoroutine);
				isPulsing = false;
				moveCounter.transform.localScale = global::UnityEngine.Vector3.one;
			}
			return;
		}
		if (moveCount == 5)
		{
			StartCoroutine(ShowMovePopup(moveCount));
		}
		moveCounter.color = new global::UnityEngine.Color(1f, 0.74f, 0.37f, 1f);
		if (!isPulsing)
		{
			pulseCoroutine = StartCoroutine(PulseForever());
		}
	}

	private void OnSettingsButtonClicked()
	{
		Viewport.GetViewport<SettingsScreen>().Show();
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000440")]
	[global::Cpp2ILInjected.Address(RVA = "0x101EB70", Offset = "0x101EB70", Length = "0x78")]
	private global::System.Collections.IEnumerator PulseForever()
	{
		isPulsing = true;
		float timer = 0f;
		while (true)
		{
			timer += global::UnityEngine.Time.deltaTime;
			float sawtooth = global::UnityEngine.Mathf.Repeat(timer, 2f) - 1f;
			float triangle = global::UnityEngine.Mathf.Abs(sawtooth);
			float scale = 1f + (1f - triangle) * 0.25f;
			moveCounter.transform.localScale = new global::UnityEngine.Vector3(scale, scale, 1f);
			yield return null;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000441")]
	[global::Cpp2ILInjected.Address(RVA = "0x101EAF8", Offset = "0x101EAF8", Length = "0x78")]
	private global::System.Collections.IEnumerator ShowMovePopup(int moves)
	{
		global::UnityEngine.GameObject effect = global::UnityEngine.Object.Instantiate(moveEffectPrefab, moveEffectParent);
		global::UnityEngine.RectTransform effectRect = effect.GetComponent<global::UnityEngine.RectTransform>();
		effectRect.position = moveEffectParent.transform.position;
		global::ElasticScale elasticScale = effect.GetComponent<global::ElasticScale>();
		elasticScale.SetScale(0f);
		elasticScale.Pop();
		global::UnityEngine.Vector3 endValue = effectRect.position + global::UnityEngine.Vector3.up * 500f;
		global::DG.Tweening.ShortcutExtensions.DOMove(effect.transform, endValue, 2f);
		yield return new global::UnityEngine.WaitForSeconds(1f);
		global::UnityEngine.CanvasGroup canvasGroup = effect.GetComponent<global::UnityEngine.CanvasGroup>();
		global::DG.Tweening.DOTweenModuleUI.DOFade(canvasGroup, 0f, 1f);
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000442")]
	[global::Cpp2ILInjected.Address(RVA = "0x101E6A8", Offset = "0x101E6A8", Length = "0xD8")]
	private void UpdateMoveCounter()
	{
		moveCounter.text = Singleton<GameManager>.Instance.level.moveCount.ToString();
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000443")]
	[global::Cpp2ILInjected.Address(RVA = "0x101EC40", Offset = "0x101EC40", Length = "0x88")]
	public GameplayScreen()
	{
	}
}
