using System.Collections;
using UnityEngine;

[global::Cpp2ILInjected.Token(Token = "0x20000E5")]
public class LevelIntroScreen : Viewport
{
	#region Fields
	public GoalUI goalPrefab;

	public RectTransform goalParent;

	public GoalUI[] goals;

	public TMPro.TextMeshProUGUI levelText;

	public ElasticScale goalDialog;
	#endregion

	#region Unity Callbacks
	protected internal override void Awake()
	{
		base.Awake();
		Singleton<GameManager>.Instance.OnInit += OnInit;
	}
	#endregion

	#region Protected Methods
	protected internal override void OnStartShow()
	{
		StartCoroutine(HandleStartShow());
	}
	#endregion

	#region Private Methods
	private void OnInit()
	{
		GameManager gameManager = Singleton<GameManager>.Instance;
		goals = new GoalUI[gameManager.level.goals.Count];
		for (int i = 0; i < gameManager.level.goals.Count; i++)
		{
			GoalUI goal = Object.Instantiate(goalPrefab);
			goal.transform.SetParent(goalParent.transform, false);
			goal.Init(i);
			goals[i] = goal;
		}
		levelText.text = "Level " + (ApplicationManager.appData.playerData.levelIndex + 1);
	}

	private IEnumerator HandleStartShow()
	{
		levelText.gameObject.SetActive(false);
		goalDialog.gameObject.SetActive(false);
		yield return new WaitForSeconds(0.5f);
		levelText.gameObject.SetActive(true);
		ElasticScale levelTextScale = levelText.GetComponent<ElasticScale>();
		levelTextScale.SetScale(0f);
		levelTextScale.Pop();
		yield return new WaitForSeconds(0.2f);
		goalDialog.gameObject.SetActive(true);
		goalDialog.SetScale(0f);
		goalDialog.Pop();
	}
	#endregion
}
