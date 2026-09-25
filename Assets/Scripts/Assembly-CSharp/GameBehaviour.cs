using System.Collections;
using DG.Tweening;
using UnityEngine;

public class GameBehaviour : MonoBehaviour
{
    public RectTransform startBanner;
    public CanvasGroup objectiveBanner;

    private void Start()
    {
        StartCoroutine(IntroSequence());
    }

    private IEnumerator IntroSequence()
    {
        objectiveBanner.alpha = 0f;
        yield return new WaitForSeconds(0.5f);

        startBanner.DOAnchorMin(new Vector2(0f, 0.5f), 0.5f).SetEase(Ease.OutBack);
        startBanner.DOAnchorMax(new Vector2(1f, 0.5f), 0.5f).SetEase(Ease.OutBack);
        yield return new WaitForSeconds(2f);

        startBanner.DOAnchorMin(new Vector2(0f, 1.5f), 0.4f).SetEase(Ease.InBack);
        yield return startBanner.DOAnchorMax(new Vector2(1f, 1.5f), 0.4f).SetEase(Ease.InBack).WaitForCompletion();

        objectiveBanner.DOFade(1f, 0.5f);
    }

    private void Update()
    {
    }

    private void OnDestroy()
    {
        startBanner.DOKill();
        objectiveBanner.DOKill();
    }
}
