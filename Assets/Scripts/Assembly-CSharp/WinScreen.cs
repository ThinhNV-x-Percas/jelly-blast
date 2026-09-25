using System.Collections;
using TapticPlugin;
using UnityEngine;

public class WinScreen : Viewport
{
    public TextPopEffect titleTextEffect;

    protected internal override void OnStartShow()
    {
        StartCoroutine(HandleStartShow());
    }

    private IEnumerator HandleStartShow()
    {
        titleTextEffect.gameObject.SetActive(false);
        yield return new WaitForSeconds(0.1f);
        Singleton<AudioManager>.Instance.PlayClip("level complete", new AudioClipSettings { pitch = 1.8f });
        if (ApplicationManager.appData.playerData.hapticOn)
        {
            TapticManager.Impact(ImpactFeedback.Heavy);
        }
        titleTextEffect.gameObject.SetActive(true);
        titleTextEffect.StartTransition();
    }
}
