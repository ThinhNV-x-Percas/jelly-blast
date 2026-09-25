using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : Singleton<AudioManager>
{
    public AudioMixer masterMixer;
    public AudioSource sourcePrefab;
    public bool enableSounds;

    private void Start()
    {
        UpdateVolume();
    }

    public void PlayClip(AudioClip clip, AudioClipSettings settings)
    {
        if (!enableSounds || !clip || !ApplicationManager.appData.playerData.soundsOn)
        {
            return;
        }

        AudioSource source = Instantiate(sourcePrefab);
        float pitchOffset = Random.Range(settings.pitchVariance * -0.5f, settings.pitchVariance * 0.5f);
        source.pitch = Time.timeScale * (settings.pitch + pitchOffset);
        source.volume = settings.volume;
        source.clip = clip;
        source.Play();
        Destroy(source.gameObject, clip.length * 3f);
    }

    public void PlayClip(AudioClip clip)
    {
        PlayClip(clip, new AudioClipSettings());
    }

    public void PlayClip(string clipName)
    {
        PlayClip(clipName, new AudioClipSettings());
    }

    public void PlayClip(string clipName, AudioClipSettings settings)
    {
        AudioClipManager clipManager = AudioClipManager.Instance;
        if (clipManager != null && clipManager.GetAudioClip(clipName, out AudioClip clip))
        {
            PlayClip(clip, settings);
        }
    }

    public void UpdateVolume()
    {
        masterMixer.SetFloat("masterVolume", ApplicationManager.appData.playerData.soundsOn ? 0f : -80f);
    }
}
