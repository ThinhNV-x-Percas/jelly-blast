using System.Collections;
using UnityEngine;

[global::Cpp2ILInjected.Token(Token = "0x20000D8")]
public class GameUIManager : MonoBehaviour
{
	private void Awake()
	{
		Singleton<GameManager>.Instance.OnGameStateChanged += OnGameStateChanged;
	}

	private void OnDestroy()
	{
		GameManager gameManager = Singleton<GameManager>.Instance;
		if (gameManager != null)
		{
			gameManager.OnGameStateChanged -= OnGameStateChanged;
		}
	}

	// The shipped body is a jump table the decompiler could not resolve, and every
	// Viewport.GetViewport<T> in it lost its type argument. Rebuilt from the screens
	// the scene actually carries and from the two coroutines' surviving structure.
	private void OnGameStateChanged(GameState fromState, GameState toState)
	{
		if (fromState == GameState.None)
		{
			Viewport.GetViewport<TransitionScreen>().Hide();
		}

		switch (toState)
		{
			case GameState.EstablishingShot:
				Viewport.GetViewport<LevelIntroScreen>().Hide();
				break;

			case GameState.IntroScreen:
				Viewport.GetViewport<LevelIntroScreen>().Show();
				break;

			case GameState.Gameplay:
				Viewport.GetViewport<LevelIntroScreen>().Hide();
				Viewport.GetViewport<GameplayScreen>().Show();
				Viewport.GetViewport<InputPanelScreen>().Show();
				break;

			case GameState.Win:
				StartCoroutine(HandleWin());
				break;

			case GameState.Fail:
				StartCoroutine(HandleFail());
				break;
		}
	}

	private IEnumerator HandleWin()
	{
		yield return new WaitForSeconds(1.5f);

		Viewport.GetViewport<GameplayScreen>().Hide();
		Viewport.GetViewport<InputPanelScreen>().Hide();
		Viewport.GetViewport<TintScreen>().Show();
		Viewport.GetViewport<ConfettiScreen>().Show(0f);
		Viewport.GetViewport<WinScreen>().Show();

		yield return new WaitForSeconds(3f);

		Viewport.GetViewport<WinScreen>().Hide();
		Viewport.GetViewport<LevelCompleteScreen>().Show();
		Viewport.GetViewport<CoinsScreen>().Show();
	}

	private IEnumerator HandleFail()
	{
		yield return new WaitForSeconds(0f);

		Viewport.GetViewport<GameplayScreen>().Hide();
		Viewport.GetViewport<InputPanelScreen>().Hide();
		Viewport.GetViewport<LevelIntroScreen>().Hide();
		Viewport.GetViewport<TintScreen>().Show();
		Viewport.GetViewport<FailScreen>().Show();

		yield return new WaitForSeconds(3f);

		Viewport.GetViewport<FailScreen>().Hide();
		Viewport.GetViewport<LevelFailedScreen>().Show();
	}
}
