using System.Collections;
using TMPro;
using UnityEngine;

public class LevelIntroScreen : Viewport
{
    public GoalUI goalPrefab;
    public RectTransform goalParent;
    public GoalUI[] goals;
    public TextMeshProUGUI levelText;
    public ElasticScale goalDialog;

    protected internal override void Awake()
    {
        base.Awake();
        Singleton<GameManager>.Instance.OnInit += OnInit;
    }

    protected internal override void OnStartShow()
    {
        StartCoroutine(HandleStartShow());
    }

    private void OnInit()
    {
        Level level = Singleton<GameManager>.Instance.level;
        goals = new GoalUI[level.goals.Count];
        for (int i = 0; i < level.goals.Count; i++)
        {
            GoalUI goal = Instantiate(goalPrefab);
            goal.transform.SetParent(goalParent.transform, false);
            goal.Init(i);
            goals[i] = goal;
        }

        levelText.text = "Level " + (ApplicationManager.appData.playerData.levelIndex + 1);
    }

    private IEnumerator HandleStartShow()
    {
        levelText.gameObject.SetActive(false);
        goalDialog.gameObject.SetActive(false);
        yield return new WaitForSeconds(0.5f);

        levelText.gameObject.SetActive(true);
        ElasticScale levelTextScale = levelText.GetComponent<ElasticScale>();
        levelTextScale.SetScale(0f);
        levelTextScale.Pop();
        yield return new WaitForSeconds(0.2f);

        goalDialog.gameObject.SetActive(true);
        goalDialog.SetScale(0f);
        goalDialog.Pop();
    }
}
