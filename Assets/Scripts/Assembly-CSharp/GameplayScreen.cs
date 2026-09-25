using System.Collections;
using DG.Tweening;
using TMPro;
using UnityEngine;

public class GameplayScreen : Viewport
{
    public GoalUI goalPrefab;
    public RectTransform goalParent;
    public GoalUI[] goals;
    public TextMeshProUGUI moveCounter;
    public UIButton settingsButton;
    public GameObject moveEffectPrefab;
    public RectTransform moveEffectParent;

    private Coroutine pulseCoroutine;

    public UIIconGenerator iconGenerator;
    public ElasticScale moveCountElasticScale;

    private bool isPulsing;

    protected internal override void Awake()
    {
        base.Awake();
        Singleton<GameManager>.Instance.OnInit += OnInit;
    }

    protected override void OnDestroy()
    {
        base.OnDestroy();
        GameManager gameManager = Singleton<GameManager>.Instance;
        if (gameManager != null)
        {
            gameManager.OnInit -= OnInit;
            gameManager.OnUserMove -= OnUserMove;
        }
    }

    private void OnInit()
    {
        int goalCount = Singleton<GameManager>.Instance.level.goals.Count;
        goals = new GoalUI[goalCount];
        for (int i = 0; i < goalCount; i++)
        {
            GoalUI goal = Instantiate(goalPrefab);
            goal.transform.SetParent(goalParent.transform, false);
            goal.Init(i);
            goals[i] = goal;
        }

        settingsButton.m_OnClick.AddListener(() => GetViewport<SettingsScreen>().Show());
        Singleton<GameManager>.Instance.OnUserMove += OnUserMove;
        UpdateMoveCounter();
    }

    public Vector2 GetWorldGoalPosition(int index)
    {
        RectTransform goalRect = goals[index].GetComponent<RectTransform>();
        return Camera.main.ScreenToWorldPoint(goalRect.position);
    }

    private void OnUserMove()
    {
        int moveCount = Singleton<GameManager>.Instance.level.moveCount;
        moveCounter.text = moveCount.ToString();
        moveCountElasticScale.Pop();

        if (moveCount > 5)
        {
            moveCounter.color = Color.white;
            if (isPulsing)
            {
                StopCoroutine(pulseCoroutine);
                isPulsing = false;
                moveCounter.transform.localScale = Vector3.one;
            }
            return;
        }

        if (moveCount == 5)
        {
            StartCoroutine(ShowMovePopup(moveCount));
        }

        moveCounter.color = new Color(1f, 0.74f, 0.37f, 1f);
        if (!isPulsing)
        {
            pulseCoroutine = StartCoroutine(PulseForever());
        }
    }

    private IEnumerator PulseForever()
    {
        isPulsing = true;
        float timer = 0f;
        while (true)
        {
            timer += Time.deltaTime;
            float scale = Mathf.Lerp(1f, 1.25f, 1f - Mathf.Abs(Mathf.Repeat(timer, 2f) - 1f));
            moveCounter.transform.localScale = new Vector3(scale, scale, 1f);
            yield return null;
        }
    }

    private IEnumerator ShowMovePopup(int moves)
    {
        GameObject effect = Instantiate(moveEffectPrefab, moveEffectParent);
        RectTransform effectRect = effect.GetComponent<RectTransform>();
        effectRect.position = moveEffectParent.transform.position;

        ElasticScale elasticScale = effect.GetComponent<ElasticScale>();
        elasticScale.SetScale(0f);
        elasticScale.Pop();

        effect.transform.DOMove(effectRect.position + Vector3.up * 500f, 2f);
        yield return new WaitForSeconds(1f);

        effect.GetComponent<CanvasGroup>().DOFade(0f, 1f);
    }

    private void UpdateMoveCounter()
    {
        moveCounter.text = Singleton<GameManager>.Instance.level.moveCount.ToString();
    }
}
