using UnityEngine;
using UnityEngine.SceneManagement;

public class Loader : Singleton<Loader>
{
    [SerializeField]
    private string startSceneName;

    [SerializeField]
    private bool loadNextBuildSceneWhenNameIsEmpty = true;

    private void Start()
    {
        StartGame();
    }

    private void StartGame()
    {
        if (!string.IsNullOrWhiteSpace(startSceneName))
        {
            SceneManager.LoadScene(startSceneName);
            return;
        }

        if (!loadNextBuildSceneWhenNameIsEmpty)
        {
            Debug.LogWarning($"{nameof(Loader)}: Start scene name is empty.");
            return;
        }

        Scene activeScene = SceneManager.GetActiveScene();
        int nextBuildIndex = activeScene.buildIndex + 1;

        if (nextBuildIndex < 0 || nextBuildIndex >= SceneManager.sceneCountInBuildSettings)
        {
            Debug.LogWarning(
                $"{nameof(Loader)}: No next scene exists in Build Settings. " +
                "Set Start Scene Name in the Inspector.");
            return;
        }

        SceneManager.LoadScene(nextBuildIndex);
    }
}
