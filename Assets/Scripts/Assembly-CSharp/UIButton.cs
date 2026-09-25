using System;
using TapticPlugin;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class UIButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerClickHandler, IPointerUpHandler
{
    [Serializable]
    public class UIButtonClickedEvent : UnityEvent
    {
    }

    [SerializeField]
    public UIButtonClickedEvent m_OnClick = new UIButtonClickedEvent();

    [HideInInspector]
    public ElasticScale elasticScale;

    public UIButtonClickedEvent onClick
    {
        get => m_OnClick;
        set => m_OnClick = value;
    }

    protected UIButton()
    {
    }

    private void Awake()
    {
        elasticScale = GetComponent<ElasticScale>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Singleton<AudioManager>.Instance?.PlayClip("hit");
        if (elasticScale != null)
        {
            elasticScale.targetScale = 0.8f;
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        TapticManager.Impact(ImpactFeedback.Medium);
        m_OnClick?.Invoke();
        Singleton<AudioManager>.Instance?.PlayClip("click");
        if (elasticScale == null)
        {
            return;
        }
        elasticScale.targetScale = 1f;
        elasticScale.Pop();
    }
}
