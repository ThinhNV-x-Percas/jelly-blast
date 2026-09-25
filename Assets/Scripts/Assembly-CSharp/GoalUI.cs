using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GoalUI : MonoBehaviour
{
    #region Fields
    private int goalIndex;

    public TextMeshProUGUI goalText;
    public Image goalImage;
    public GameObject tick;

    private GoalData goal;
    private ElasticScale elasticScale;
    #endregion

    #region Unity Callbacks
    private void Awake()
    {
        elasticScale = GetComponent<ElasticScale>();
        tick.SetActive(false);
        goalText.gameObject.SetActive(true);
    }
    #endregion

    #region Public Methods
    public void Init(int _goalIndex)
    {
        goalIndex = _goalIndex;
        goal = Singleton<GameManager>.Instance.level.goals[goalIndex];
        goal.displayedCount = goal.count;
        goalText.text = goal.count.ToString();
        goalImage.sprite = goal.sprite;
        if (goal.goalType == GoalType.Bee)
            goalImage.rectTransform.sizeDelta *= 0.75f;
    }

    public void RecieveParticle()
    {
        goal.displayedCount--;
        if (goal.displayedCount > 0)
        {
            goalText.text = goal.displayedCount.ToString();
        }
        else
        {
            tick.SetActive(true);
            goalText.gameObject.SetActive(false);
        }
        elasticScale.Pop();
    }
    #endregion
}
