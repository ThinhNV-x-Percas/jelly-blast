using System.Collections;
using UnityEngine;

[global::Cpp2ILInjected.Token(Token = "0x20000F2")]
public class LevelFailedScreen : Viewport
{
	#region Fields
	public UIButton retryButton;
	#endregion

	#region Unity Callbacks
	private void Start()
	{
		retryButton.m_OnClick.AddListener(() =>
		{
			Hide();
			Singleton<GameManager>.Instance.Reset();
		});
	}
	#endregion

	#region Protected Methods
	protected internal override void OnStartShow()
	{
		StartCoroutine(HandleStartShow());
	}
	#endregion

	#region Private Methods
	private IEnumerator HandleStartShow()
	{
		retryButton.gameObject.SetActive(false);
		yield return new WaitForSeconds(0.1f);
		Singleton<AudioManager>.Instance.PlayClip("bubble pop");
		retryButton.gameObject.SetActive(true);
		retryButton.elasticScale.SetScale(0f);
		retryButton.elasticScale.Pop();
	}
	#endregion
}
