using System;
using TMPro;

public class SettingsScreen : Viewport
{
    public UIButton backButton;
    public UIButton hapticButton;

    private UIButtonStyler hapticButtonStyler;

    public UIButton soundsButton;

    private UIButtonStyler soundsButtonStyler;

    public UIButton resetButton;
    public UIButtonStyle onButtonStyle;
    public UIButtonStyle offButtonStyle;

    private void Start()
    {
        hapticButtonStyler = hapticButton.GetComponent<UIButtonStyler>();
        soundsButtonStyler = soundsButton.GetComponent<UIButtonStyler>();
        resetButton.gameObject.SetActive(Singleton<ApplicationManager>.Instance.isDeveloperMode);
        resetButton.m_OnClick.AddListener(ResetGameData);
        backButton.m_OnClick.AddListener(() => Hide());
        AddButtonListener(hapticButton, ApplicationManager.ToggleHaptic, UpdateHapticVisual);
        AddButtonListener(soundsButton, ApplicationManager.ToggleSounds, UpdateSoundsVisual);
        UpdateAllVisuals();
    }

    private void AddButtonListener(UIButton button, Action toggleAction, Action updateVisualAction)
    {
        button.m_OnClick.AddListener(() =>
        {
            toggleAction();
            updateVisualAction();
        });
    }

    public void UpdateAllVisuals()
    {
        UpdateButtonVisual(hapticButton, "Haptic", ApplicationManager.appData.playerData.hapticOn);
        UpdateButtonVisual(soundsButton, "Sounds", ApplicationManager.appData.playerData.soundsOn);
    }

    public void UpdateHapticVisual()
    {
        UpdateButtonVisual(hapticButton, "Haptic", ApplicationManager.appData.playerData.hapticOn);
    }

    public void UpdateSoundsVisual()
    {
        UpdateButtonVisual(soundsButton, "Sounds", ApplicationManager.appData.playerData.soundsOn);
    }

    private void UpdateButtonVisual(UIButton button, string label, bool isOn)
    {
        button.GetComponentInChildren<TextMeshProUGUI>().text = label + ": " + (isOn ? "ON" : "OFF");

        if (hapticButton.gameObject.activeInHierarchy)
        {
            hapticButtonStyler.SetStyle(ApplicationManager.appData.playerData.hapticOn ? onButtonStyle : offButtonStyle);
        }

        if (soundsButton.gameObject.activeInHierarchy)
        {
            soundsButtonStyler.SetStyle(ApplicationManager.appData.playerData.soundsOn ? onButtonStyle : offButtonStyle);
        }
    }

    public void ResetGameData()
    {
        GetViewport<TransitionScreen>().Show();
        ApplicationManager.appData.ClearPlayerData();
        Singleton<ApplicationManager>.Instance.LoadScene(0);
    }
}
