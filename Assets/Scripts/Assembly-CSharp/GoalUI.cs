using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GoalUI : MonoBehaviour
{
    private int goalIndex;

    public TextMeshProUGUI goalText;
    public Image goalImage;
    public GameObject tick;

    private GoalData goal;
    private ElasticScale elasticScale;

    private void Awake()
    {
        elasticScale = GetComponent<ElasticScale>();

        if (tick != null)
        {
            tick.SetActive(false);
        }

        if (goalText != null)
        {
            goalText.gameObject.SetActive(true);
        }
    }

    public void Init(int _goalIndex)
    {
        goalIndex = _goalIndex;

        GameManager gameManager = Singleton<GameManager>.Instance;
        if (gameManager == null || gameManager.level == null || gameManager.level.goals == null)
        {
            return;
        }

        if (goalIndex < 0 || goalIndex >= gameManager.level.goals.Count)
        {
            return;
        }

        goal = gameManager.level.goals[goalIndex];
        if (goal == null)
        {
            return;
        }

        goal.displayedCount = goal.count;

        if (goalText != null)
        {
            goalText.text = goal.count.ToString();
        }

        if (goalImage != null)
        {
            goalImage.sprite = goal.sprite;

            // Bee icons use a smaller display size in the original implementation.
            if (goal.goalType == GoalType.Bee)
            {
                RectTransform rectTransform = goalImage.rectTransform;
                rectTransform.sizeDelta *= 0.75f;
            }
        }
    }

    public void RecieveParticle()
    {
        if (goal == null)
        {
            return;
        }

        goal.displayedCount--;

        if (goal.displayedCount > 0)
        {
            if (goalText != null)
            {
                goalText.text = goal.displayedCount.ToString();
            }
        }
        else
        {
            if (tick != null)
            {
                tick.SetActive(true);
            }

            if (goalText != null)
            {
                goalText.gameObject.SetActive(false);
            }
        }

        if (elasticScale != null)
        {
            elasticScale.Pop();
        }
    }
}
