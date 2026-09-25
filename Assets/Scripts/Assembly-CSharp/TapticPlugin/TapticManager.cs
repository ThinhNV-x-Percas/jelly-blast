using System.Runtime.InteropServices;

namespace TapticPlugin
{
    public static class TapticManager
    {
        public static void Notification(NotificationFeedback feedback)
        {
#if UNITY_IOS && !UNITY_EDITOR
            _unityTapticNotification((int)feedback);
#endif
        }

        public static void Impact(ImpactFeedback feedback)
        {
            if (!ApplicationManager.appData.playerData.hapticOn)
            {
                return;
            }
#if UNITY_IOS && !UNITY_EDITOR
            _unityTapticImpact((int)feedback);
#endif
        }

        public static void Selection()
        {
#if UNITY_IOS && !UNITY_EDITOR
            _unityTapticSelection();
#endif
        }

        public static bool IsSupport()
        {
#if UNITY_IOS && !UNITY_EDITOR
            return _unityTapticIsSupport();
#else
            return false;
#endif
        }

        [DllImport("__Internal")]
        private static extern void _unityTapticNotification(int type);

        [DllImport("__Internal")]
        private static extern void _unityTapticSelection();

        [DllImport("__Internal")]
        private static extern void _unityTapticImpact(int style);

        [DllImport("__Internal")]
        private static extern bool _unityTapticIsSupport();
    }
}
