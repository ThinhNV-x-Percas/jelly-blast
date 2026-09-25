using System.Collections;
using DG.Tweening;
using TMPro;
using UnityEngine;

public class CollectRegionTextEffect : MonoBehaviour
{
    public GameObject effectPrefab;

    private FluidSolver solver;

    private void Awake()
    {
        Singleton<GameManager>.Instance.OnInit += OnInit;
    }

    private void OnDestroy()
    {
        if (solver != null)
        {
            solver.OnRemoveRegionStart -= OnRemoveRegionStart;
        }

        GameManager gameManager = Singleton<GameManager>.Instance;
        if (gameManager != null)
        {
            gameManager.OnInit -= OnInit;
            gameManager.OnTooSmallReject -= OnTooSmallReject;
        }
    }

    public void OnInit()
    {
        solver = Singleton<GameManager>.Instance.solver;
        solver.OnRemoveRegionStart += OnRemoveRegionStart;
        Singleton<GameManager>.Instance.OnTooSmallReject += OnTooSmallReject;
    }

    public void OnRemoveRegionStart(bool createPowerup, Vector2 wPos)
    {
        if (!createPowerup)
        {
            return;
        }
        StartCoroutine(HandleEffect(Camera.main.WorldToScreenPoint(wPos), "Great!"));
    }

    public void OnTooSmallReject(Vector2 wPos)
    {
        StartCoroutine(HandleEffect(Camera.main.WorldToScreenPoint(wPos), "Too small"));
    }

    private IEnumerator HandleEffect(Vector2 pos, string content)
    {
        GameObject effect = Instantiate(effectPrefab);
        effect.transform.SetParent(transform);
        effect.GetComponentInChildren<TextMeshProUGUI>().text = content;
        effect.GetComponent<RectTransform>().position = pos;

        ElasticScale elasticScale = effect.GetComponent<ElasticScale>();
        elasticScale.SetScale(0f);
        elasticScale.Pop();

        effect.transform.DOMove(pos + Vector2.up * 180f, 0.5f);
        yield return new WaitForSeconds(0.5f);

        effect.GetComponent<CanvasGroup>().DOFade(0f, 0.25f);
    }
}
