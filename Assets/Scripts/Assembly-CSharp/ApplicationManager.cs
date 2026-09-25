using System;
using System.Collections;
using DG.Tweening;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ApplicationManager : Singleton<ApplicationManager>
{
    private static ApplicationData _applicationData;

    private bool loadingScene;

    private float sceneTransitionDuration = 0.75f;

    public bool isDeveloperMode = true;

    public static Action OnSceneChanged;

    public static ApplicationData appData
    {
        get
        {
            if (_applicationData == null)
            {
                _applicationData = Resources.Load<ApplicationData>("ApplicationData");
            }
            return _applicationData;
        }
    }

    protected override void OnAwake()
    {
        DOTween.Init(false, true, LogBehaviour.ErrorsOnly).SetCapacity(1000, 100);
        appData.LoadPlayerData();
        Application.targetFrameRate = 60;
        Input.multiTouchEnabled = false;
        WarmUpJsonHelper();
    }

    private void WarmUpJsonHelper()
    {
        string json = JsonHelper.Serialize(new float2(0f, 0f));
        JsonHelper.Deserialize<float2>(json);
    }

    private void OnApplicationPause(bool paused)
    {
        // Mobile platforms usually kill a backgrounded app without calling OnApplicationQuit.
        if (paused)
        {
            appData.SavePlayerData();
        }
    }

    private void OnApplicationQuit()
    {
        appData.SavePlayerData();
    }

    public void ReloadActiveScene()
    {
        LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void LoadScene(int buildIndex)
    {
        if (!loadingScene)
        {
            StartCoroutine(ExecuteLoadScene(buildIndex));
        }
    }

    private IEnumerator ExecuteLoadScene(int buildIndex)
    {
        loadingScene = true;
        appData.SavePlayerData();
        yield return new WaitForSecondsRealtime(sceneTransitionDuration);

        AsyncOperation operation = SceneManager.LoadSceneAsync(buildIndex);
        while (!operation.isDone)
        {
            yield return null;
        }

        OnSceneChanged?.Invoke();
        appData.LoadPlayerData();
        loadingScene = false;
    }

    public static void ToggleSounds()
    {
        PlayerData playerData = appData.playerData;
        playerData.soundsOn = !playerData.soundsOn;
        AudioManager audioManager = Singleton<AudioManager>.Instance;
        if (audioManager != null)
        {
            audioManager.UpdateVolume();
        }
        appData.SavePlayerData();
    }

    public static void ToggleHaptic()
    {
        PlayerData playerData = appData.playerData;
        playerData.hapticOn = !playerData.hapticOn;
        appData.SavePlayerData();
    }

    public void ResetApplication()
    {
        appData.ClearPlayerData();
        appData.LoadPlayerData();
        ReloadActiveScene();
    }
}
