using System;
using UnityEngine;
public class AudioManagerScript : MonoBehaviour
{

    public Sound[] sounds;
    public static AudioManagerScript instance;
    private AudioSource audioSrc;
    private float musicVolume = 1f;



    void Awake()
    {


        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
        audioSrc = sounds[0].getAudioSource();
        Play("Background");
    }

    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            return;
        }

        s.source.Play();
    }

    private void Update()
    {
        audioSrc.volume = musicVolume;
    }
    public void Start()
    {
        musicVolume = PlayerPrefs.GetFloat("Volume", 1f);
        Play("SoundTrack");
    }

    public void SetVolume(float vol)
    {
        PlayerPrefs.SetFloat("Volume", vol);
        musicVolume = vol;

    }
    public void Stop()
    {
        audioSrc.Stop();

    }
}