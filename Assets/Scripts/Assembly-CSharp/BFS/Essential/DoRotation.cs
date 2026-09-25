using System;
using System.Threading.Tasks;
using UnityEngine;

namespace BFS.Essential
{
    public class DoRotation : Tween
    {
        internal async Task ValueTo(Quaternion start, Quaternion end, float duration, Action<Quaternion> callback)
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
                callback?.Invoke(Quaternion.LerpUnclamped(start, end, m_Interpolator(lerp)));
                await Task.Yield();
            }
            while (lerp < 1f);
            Kill(true);
        }

        public Tween Play(Quaternion start, Quaternion end, float duration, Action<Quaternion> callback)
        {
            m_Task = ValueTo(start, end, duration, callback);
            return this;
        }
    }
}
