using System.Collections;
using TapticPlugin;
using TMPro;
using UnityEngine;

public class LevelCompleteScreen : Viewport
{
    public UIButton nextButton;
    public ElasticScale dialog;
    public TextMeshProUGUI coinsCollectedText;
    public TextMeshProUGUI levelText;
    public float conversionDuration = 1f;

    private const string CoinSprite = "<sprite index=4>";

    private void Start()
    {
        levelText.text = "Level " + (ApplicationManager.appData.playerData.levelIndex + 1);
        nextButton.m_OnClick.AddListener(() =>
        {
            Hide();
            Singleton<GameManager>.Instance.Reset();
        });
    }

    protected internal override void OnStartShow()
    {
        StartCoroutine(HandleStartShow());
    }

    private IEnumerator HandleStartShow()
    {
        dialog.gameObject.SetActive(false);
        nextButton.gameObject.SetActive(false);
        coinsCollectedText.gameObject.SetActive(false);
        yield return new WaitForSeconds(0.5f);

        Singleton<AudioManager>.Instance.PlayClip("bubble pop");
        dialog.gameObject.SetActive(true);
        dialog.SetScale(0f);
        dialog.Pop();
        yield return new WaitForSeconds(0.3f);

        coinsCollectedText.gameObject.SetActive(true);
        ElasticScale coinsScale = coinsCollectedText.GetComponent<ElasticScale>();
        coinsScale.SetScale(0f);
        coinsScale.targetScale = 1.5f;

        GameManager gameManager = Singleton<GameManager>.Instance;
        float startTime = Time.time;
        string lastText = string.Empty;
        while (Time.time < startTime + conversionDuration)
        {
            int count = (int)((Time.time - startTime) * gameManager.coinsCollected / conversionDuration);
            coinsCollectedText.text = NumberFormatter.FormatNumber(count) + CoinSprite;
            if (coinsCollectedText.text != lastText)
            {
                Singleton<AudioManager>.Instance.PlayClip("coin collect", new AudioClipSettings { volume = 0.4f });
                lastText = coinsCollectedText.text;
            }

            yield return null;
        }

        coinsCollectedText.text = NumberFormatter.FormatNumber(gameManager.coinsCollected) + CoinSprite;
        coinsScale.Pop();
        Viewport.GetViewport<CoinsScreen>().ShowCoinAnim(gameManager.coinsCollected);
        coinsScale.targetScale = 1f;
        if (ApplicationManager.appData.playerData.hapticOn)
        {
            TapticManager.Impact(ImpactFeedback.Heavy);
        }

        yield return new WaitForSeconds(0.4f);

        nextButton.gameObject.SetActive(true);
        nextButton.elasticScale.SetScale(0f);
        nextButton.elasticScale.Pop();
    }
}
