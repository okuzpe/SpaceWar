using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class Sound
{

    public string name;
    public AudioClip clip;

    [Range(0f, 1f)]
    public float volume;
    [Range(.1f, 3f)]
    public float pitch;

    public bool loop;

    [HideInInspector]
    public AudioSource source;

    public float getVolume()
    {
        return this.volume;
    }

    public void setVolume(float volu)
    {
        this.volume = volu;
    }

    public AudioSource getAudioSource()
    {
        return this.source;
    }
}
