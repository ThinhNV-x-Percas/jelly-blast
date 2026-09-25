using System;
using BFS.Essential.TweenCore;
using UnityEngine;

namespace BFS.Essential
{
    public static class MyTween
    {
        public static Tween DoFloat(float start, float end, float duration, Action<float> callback)
        {
            var tween = new TweenCore.DoFloat();
            tween.m_Task = tween.ValueTo(start, end, duration, callback);
            return tween;
        }

        public static Tween DoDelay(float duration, Action callback)
        {
            var tween = new TweenCore.DoDelay();
            tween.m_Task = tween.Delay(duration, callback);
            return tween;
        }

        public static Tween DoColor(Color start, Color end, float duration, Action<Color> callback)
        {
            var tween = new TweenCore.DoColor();
            tween.m_Task = tween.ValueTo(start, end, duration, callback);
            return tween;
        }

        public static Tween DoVector(Vector3 start, Vector3 end, float duration, Action<Vector3> callback)
        {
            var tween = new TweenCore.DoVector();
            tween.m_Task = tween.ValueTo(start, end, duration, callback);
            return tween;
        }

        public static Tween DoRotation(Quaternion start, Quaternion end, float duration, Action<Quaternion> callback)
        {
            var tween = new Essential.DoRotation();
            tween.m_Task = tween.ValueTo(start, end, duration, callback);
            return tween;
        }

        public static void KillAll()
        {
            while (Tween._Tweens.Count > 0)
            {
                Tween._Tweens[0].Kill();
            }
        }
    }
}
