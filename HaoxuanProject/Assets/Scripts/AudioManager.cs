using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public AudioClip battleSceneMusic;
    public AudioClip mainSceneMusic;
    public AudioSource musicSource;
    public AudioSource soundfxSource;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this);
    }

    public void PlayBattleMusic()
    {
        musicSource.clip = battleSceneMusic;
        musicSource.Play();
    }

    public void PlayMainMusic()
    {
        musicSource.clip = mainSceneMusic;
        musicSource.Play();
    }

    public void PlaySoundFX()
    {
        soundfxSource.Play();
    }
}
