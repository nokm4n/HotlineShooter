using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource musicAudioSource;
    [SerializeField] private AudioClip[] music;
    [SerializeField] private AudioClip introMusic;
    [SerializeField] private AudioSource soundsAudioSource;

    public static AudioManager Instance;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneChanged;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneChanged;
    }

    private void OnSceneChanged(Scene _, LoadSceneMode __)
    {
        soundsAudioSource.Stop();
    }

    public void PlayOneShot(AudioClip clip)
    {
        soundsAudioSource.PlayOneShot(clip);
    }

   /* private void Start()
    {
        PlayMusic();
    }

    public void OnIntroEnd()
    {
        PlayMusic();
    }

    private void PlayMusic()
    {
        if (!SaveData.IntroPassed)
        {
            musicAudioSource.clip = introMusic;
            musicAudioSource.loop = false;
            musicAudioSource.Play();
            return;
        }

        musicAudioSource.loop = true;
        
        switch (SaveData.PassedLevels)
        {
            case < 11:
                musicAudioSource.clip = music[0];
                break;
            case < 23:
                musicAudioSource.clip = music[1];
                break;
            case < 37:
                musicAudioSource.clip = music[2];
                break;
            case < 46:
                musicAudioSource.clip = music[3];
                break;
            default:
                musicAudioSource.clip = music[4];
                break;
        }
        
        musicAudioSource.Play();
    }*/
}
