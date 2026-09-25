using System.Collections;
using UnityEngine;

public class LevelFailedScreen : Viewport
{
    public UIButton retryButton;

    private void Start()
    {
        retryButton.m_OnClick.AddListener(() =>
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
        retryButton.gameObject.SetActive(false);
        yield return new WaitForSeconds(0.1f);

        Singleton<AudioManager>.Instance.PlayClip("bubble pop");
        retryButton.gameObject.SetActive(true);
        retryButton.elasticScale.SetScale(0f);
        retryButton.elasticScale.Pop();
    }
}
