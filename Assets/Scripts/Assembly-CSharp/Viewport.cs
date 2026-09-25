using System;
using System.Collections.Generic;
using BFS.Essential;
using UnityEngine;

[RequireComponent(typeof(CanvasGroup))]
public class Viewport : MonoBehaviour
{
    public enum TransitionType
    {
        Scale = 0,
        Slide = 1
    }

    private static Dictionary<Type, Viewport> m_Viewports = new Dictionary<Type, Viewport>();

    public EasingFunction.Ease ease = EasingFunction.Ease.EaseInOutCubic;

    public bool ShouldAnimate = true;

    public RectTransform main;

    private float mainTransitionScaleDelta = 0.25f;

    private float transitionFadeRange = 0.75f;

    public TransitionType transitionType;

    [SerializeField]
    protected bool m_VisibleAtStart;

    private bool m_IsShow = true;

    private Tween m_TShowHide;

    private CanvasGroup m_CanvasGroup;

    [HideInInspector]
    public float interp;

    public CanvasGroup CanvasGroup
    {
        get
        {
            if (m_CanvasGroup == null)
            {
                m_CanvasGroup = GetComponent<CanvasGroup>();
            }
            return m_CanvasGroup;
        }
    }

    public bool IsShow => m_IsShow;

    public static t GetViewport<t>() where t : Viewport
    {
        return m_Viewports.TryGetValue(typeof(t), out Viewport viewport) && viewport != null
            ? viewport.GetComponent<t>()
            : null;
    }

    protected virtual void OnStartHide()
    {
    }

    protected virtual void OnEndHide()
    {
    }

    protected internal virtual void OnStartShow()
    {
    }

    protected virtual void OnEndShow()
    {
    }

    private void StopFadeTask()
    {
        if (m_TShowHide != null)
        {
            m_TShowHide.Kill();
            m_TShowHide = null;
        }
    }

    private void ShowHide(bool on, float duration, Action callback)
    {
        StopFadeTask();
        m_IsShow = on;
        if (on)
        {
            OnStartShow();
        }
        else
        {
            OnStartHide();
        }

        float target = on ? 1f : 0f;
        if (!ShouldAnimate)
        {
            ApplyTransition(target);
            FinishTransition(on, callback);
            return;
        }

        EasingFunction.Function easing = EasingFunction.GetEasingFunction(ease);
        m_TShowHide = MyTween.DoFloat(on ? 0f : 1f, target, duration, ApplyTransition)
            .SetInterpolator(t => easing(t))
            .OnComplete(() => FinishTransition(on, callback));
    }

    private void FinishTransition(bool on, Action callback)
    {
        if (on)
        {
            OnEndShow();
        }
        else
        {
            OnEndHide();
        }
        callback?.Invoke();
        gameObject.SetActive(on);
    }

    private void ApplyTransition(float t)
    {
        float hiddenAmount = 1f - t;
        CanvasGroup.alpha = Mathf.Clamp01(1f - hiddenAmount / transitionFadeRange);
        if (!main)
        {
            return;
        }

        if (transitionType == TransitionType.Slide)
        {
            interp = hiddenAmount;
            float offsetX = -t * main.rect.width;
            main.offsetMin = new Vector2(offsetX, main.offsetMin.y);
            main.offsetMax = new Vector2(offsetX, main.offsetMin.y);
        }
        else if (transitionType == TransitionType.Scale)
        {
            main.transform.localScale = Vector3.one * (1f + mainTransitionScaleDelta * (m_IsShow ? -hiddenAmount : hiddenAmount));
        }
    }

    private void OnOffCanvasGroup(bool on)
    {
        CanvasGroup.interactable = on;
        CanvasGroup.blocksRaycasts = on;
    }

    public void Show(float duration = 0.3f, Action callback = null)
    {
        if (!IsShow)
        {
            gameObject.SetActive(true);
            OnOffCanvasGroup(true);
            ShowHide(true, duration, callback);
        }
    }

    public void Hide(float duration = 0.3f, Action callback = null)
    {
        if (IsShow)
        {
            OnOffCanvasGroup(false);
            ShowHide(false, duration, callback);
        }
    }

    protected internal virtual void Awake()
    {
        // Indexer instead of Add: a viewport of the same type from a scene being unloaded may not be destroyed yet.
        m_Viewports[GetType()] = this;
        if (!m_VisibleAtStart)
        {
            m_IsShow = true;
            Hide(0f);
        }
    }

    protected virtual void OnDestroy()
    {
        StopFadeTask();
        if (m_Viewports.TryGetValue(GetType(), out Viewport registered) && registered == this)
        {
            m_Viewports.Remove(GetType());
        }
    }
}
