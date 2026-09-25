[global::Cpp2ILInjected.Token(Token = "0x2000051")]
public class CollectRegionTextEffect : global::UnityEngine.MonoBehaviour
{
	[global::Cpp2ILInjected.Token(Token = "0x4000123")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public global::UnityEngine.GameObject effectPrefab;

	[global::Cpp2ILInjected.Token(Token = "0x4000124")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private FluidSolver solver;

	[global::Cpp2ILInjected.Token(Token = "0x60001B7")]
	[global::Cpp2ILInjected.Address(RVA = "0xFED8A4", Offset = "0xFED8A4", Length = "0x140")]
	private void Awake()
	{
		Singleton<GameManager>.Instance.OnInit += OnInit;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60001B8")]
	[global::Cpp2ILInjected.Address(RVA = "0xFED9E4", Offset = "0xFED9E4", Length = "0x244")]
	public void OnInit()
	{
		solver = Singleton<GameManager>.Instance.solver;
		solver.OnRemoveRegionStart += OnRemoveRegionStart;
		Singleton<GameManager>.Instance.OnTooSmallReject += OnTooSmallReject;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60001B9")]
	[global::Cpp2ILInjected.Address(RVA = "0xFEDC28", Offset = "0xFEDC28", Length = "0x118")]
	public void OnRemoveRegionStart(bool createPowerup, global::UnityEngine.Vector2 wPos)
	{
		if (!createPowerup)
			return;
		StartCoroutine(HandleEffect(global::UnityEngine.Camera.main.WorldToScreenPoint(wPos), "Great!"));
	}

	[global::Cpp2ILInjected.Token(Token = "0x60001BA")]
	[global::Cpp2ILInjected.Address(RVA = "0xFEDDE0", Offset = "0xFEDDE0", Length = "0xFC")]
	public void OnTooSmallReject(global::UnityEngine.Vector2 wPos)
	{
		StartCoroutine(HandleEffect(global::UnityEngine.Camera.main.WorldToScreenPoint(wPos), "Too small"));
	}

	[global::Cpp2ILInjected.Token(Token = "0x60001BB")]
	[global::Cpp2ILInjected.Address(RVA = "0xFEDD40", Offset = "0xFEDD40", Length = "0xA0")]
	private global::System.Collections.IEnumerator HandleEffect(global::UnityEngine.Vector2 pos, string content)
	{
		global::UnityEngine.GameObject effect = global::UnityEngine.Object.Instantiate(effectPrefab);
		effect.transform.SetParent(base.transform);
		effect.GetComponentInChildren<global::TMPro.TextMeshProUGUI>().text = content;
		effect.GetComponent<global::UnityEngine.RectTransform>().position = pos;
		global::ElasticScale elasticScale = effect.GetComponent<global::ElasticScale>();
		elasticScale.SetScale(0f);
		elasticScale.Pop();
		global::DG.Tweening.ShortcutExtensions.DOMove(effect.transform, pos + global::UnityEngine.Vector2.up * 180f, 0.5f);
		yield return new global::UnityEngine.WaitForSeconds(0.5f);
		global::DG.Tweening.DOTweenModuleUI.DOFade(effect.GetComponent<global::UnityEngine.CanvasGroup>(), 0f, 0.25f);
	}

	[global::Cpp2ILInjected.Token(Token = "0x60001BC")]
	[global::Cpp2ILInjected.Address(RVA = "0xFEDF08", Offset = "0xFEDF08", Length = "0x8")]
	public CollectRegionTextEffect()
	{
	}
}
