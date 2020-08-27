using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManger : MonoBehaviour
{
    public sound[] sounds;

    public static AudioManger instance; 

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return; 
        }

        DontDestroyOnLoad(gameObject);


        foreach (sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;

            s.source.loop = s.loop;
        }
    }

    private void Start()
    {
        play("theme");
    }

    public void play(string name)
    {
        sound s = Array.Find(sounds, sound => sound.name == name);

        if (s == null)
            return; 

        s.source.Play();
    }
    

}
