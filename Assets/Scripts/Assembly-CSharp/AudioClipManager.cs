using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "AudioClipManager", menuName = "Custom/AudioClipManager", order = 1)]
public class AudioClipManager : ScriptableObject
{
    public AudioClip[] clips;

    private static AudioClipManager m_Instance;

    public Dictionary<string, AudioClip> m_ClipData;

    public static AudioClipManager Instance
    {
        get
        {
            if (m_Instance == null)
            {
                m_Instance = Resources.Load<AudioClipManager>("AudioClipManager");
                if (m_Instance == null)
                {
                    return null;
                }
            }

            if (m_Instance.m_ClipData == null)
            {
                m_Instance.InitClipData();
            }
            return m_Instance;
        }
    }

    private void InitClipData()
    {
        m_ClipData = new Dictionary<string, AudioClip>();
        if (clips == null)
        {
            return;
        }

        foreach (AudioClip clip in clips)
        {
            if (clip != null && !m_ClipData.ContainsKey(clip.name))
            {
                m_ClipData.Add(clip.name, clip);
            }
        }
    }

    public bool GetAudioClip(string id, out AudioClip result)
    {
        result = null;
        return id != null && m_ClipData.TryGetValue(id, out result);
    }
}
