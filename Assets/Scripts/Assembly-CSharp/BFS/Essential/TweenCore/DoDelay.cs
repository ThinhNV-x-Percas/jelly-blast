using System;
using System.Threading.Tasks;
using UnityEngine;

namespace BFS.Essential.TweenCore
{
    public class DoDelay : Tween
    {
        internal async Task Delay(float duration, Action callback)
        {
            m_Run = true;
            float lerp = 0f;
            do
            {
                if (!m_Run)
                {
                    return;
                }
                lerp = Mathf.Clamp01(lerp + Time.deltaTime / duration);
                await Task.Yield();
            }
            while (lerp < 1f);
            callback?.Invoke();
            Kill(true);
        }

        public Tween Play(float duration, Action callback)
        {
            m_Task = Delay(duration, callback);
            return this;
        }
    }
}
