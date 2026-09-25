using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

namespace BFS.Essential
{
    public abstract class Tween
    {
        public static List<Tween> _Tweens = new List<Tween>();

        protected internal bool m_Run;
        protected internal Task m_Task;
        public Func<float, float> m_Interpolator = t => t;

        protected event Action m_OnComplete;

        protected bool Run => m_Run;

        public Task Task => m_Task;

        protected internal Tween()
        {
            _Tweens.Add(this);
        }

        public virtual Tween OnComplete(Action callback)
        {
            m_OnComplete = callback;
            return this;
        }

        public virtual Tween SetCurve(AnimationCurve curve)
        {
            return SetInterpolator(curve.Evaluate);
        }

        public virtual Tween SetInterpolator(Func<float, float> interpolator)
        {
            m_Interpolator = interpolator;
            return this;
        }

        public virtual void Kill(bool playOnComplete = false)
        {
            m_Task = null;
            m_Run = false;
            if (playOnComplete)
            {
                m_OnComplete?.Invoke();
            }
            m_OnComplete = null;
            _Tweens.Remove(this);
        }
    }
}
