using System.Collections;
using UnityEngine;

public class GameUIManager : MonoBehaviour
{
    private GameManager gameManager;

    #region Unity Callbacks
    private void Awake()
    {
        gameManager = Singleton<GameManager>.Instance;
        gameManager.OnGameStateChanged += OnGameStateChanged;
    }

    private void OnDestroy()
    {
        if (gameManager != null)
            gameManager.OnGameStateChanged -= OnGameStateChanged;
    }
    #endregion

    #region Private Methods
    private void OnGameStateChanged(GameState fromState, GameState toState)
    {
        if (fromState == GameState.None)
            Viewport.GetViewport<TransitionScreen>().Hide();

        switch (toState)
        {
            case GameState.None:
                Viewport.GetViewport<TransitionScreen>().Show();
                break;
            case GameState.IntroScreen:
                Viewport.GetViewport<LevelIntroScreen>().Show();
                break;
            case GameState.Gameplay:
                Viewport.GetViewport<LevelIntroScreen>().Hide();
                break;
            case GameState.Fail:
                StartCoroutine(HandleFail());
                break;
            case GameState.Win:
                StartCoroutine(HandleWin());
                break;
        }
    }

    private IEnumerator HandleWin()
    {
        yield return new WaitForSeconds(1.5f);
        Viewport.GetViewport<GameplayScreen>().Hide();
        Viewport.GetViewport<CoinsScreen>().Hide();
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
        Viewport.GetViewport<SettingsScreen>().Hide();
        Viewport.GetViewport<GameplayScreen>().Hide();
        Viewport.GetViewport<CoinsScreen>().Hide();
        Viewport.GetViewport<TintScreen>().Show();
        Viewport.GetViewport<FailScreen>().Show();
        yield return new WaitForSeconds(3f);
        Viewport.GetViewport<FailScreen>().Hide();
        Viewport.GetViewport<LevelFailedScreen>().Show();
    }
    #endregion
}
