using System.Threading;
using UnityEngine;

public abstract class Singleton<T> : Singleton where T : MonoBehaviour
{
    private static T _instance;
    private static readonly object Lock = new object();

    [SerializeField]
    private bool _persistent;

    public static T Instance
    {
        get
        {
            if (_instance != null)
            {
                return _instance;
            }

            bool lockTaken = false;
            try
            {
                Monitor.Enter(Lock, ref lockTaken);

                if (_instance != null)
                {
                    return _instance;
                }

                T[] instances = UnityEngine.Object.FindObjectsOfType<T>();

                if (instances == null || instances.Length == 0)
                {
                    _instance = null;
                    return null;
                }

                if (instances.Length == 1)
                {
                    _instance = instances[0];
                    return _instance;
                }

                // Keep the first instance returned by Unity and destroy the duplicates.
                _instance = instances[0];

                for (int i = 1; i < instances.Length; i++)
                {
                    if (instances[i] != null)
                    {
                        UnityEngine.Object.Destroy(instances[i].gameObject);
                    }
                }

                return _instance;
            }
            finally
            {
                if (lockTaken)
                {
                    Monitor.Exit(Lock);
                }
            }
        }
    }

    private void Awake()
    {
        if (_persistent)
        {
            T instance = Instance;

            if (instance != null && instance != this)
            {
                UnityEngine.Object.Destroy(gameObject);
                return;
            }

            DontDestroyOnLoad(gameObject);
        }

        OnAwake();
    }

    protected virtual void OnAwake()
    {
    }
}

public abstract class Singleton : MonoBehaviour
{
    private static bool _quitting;

    public static bool Quitting
    {
        get => _quitting;
        private set => _quitting = value;
    }

    private void OnApplicationQuit()
    {
        Quitting = true;
    }

    private void OnEnable()
    {
        Quitting = false;
    }
}
