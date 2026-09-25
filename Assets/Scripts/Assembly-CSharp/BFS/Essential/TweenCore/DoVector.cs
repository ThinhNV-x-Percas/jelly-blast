using System;
using System.Threading.Tasks;
using UnityEngine;

namespace BFS.Essential.TweenCore
{
    public class DoVector : Tween
    {
        internal async Task ValueTo(Vector3 start, Vector3 end, float duration, Action<Vector3> callback)
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
                callback?.Invoke(start + (end - start) * m_Interpolator(lerp));
                await Task.Yield();
            }
            while (lerp < 1f);
            Kill(true);
        }

        public Tween Play(Vector3 start, Vector3 end, float duration, Action<Vector3> callback)
        {
            m_Task = ValueTo(start, end, duration, callback);
            return this;
        }
    }
}
