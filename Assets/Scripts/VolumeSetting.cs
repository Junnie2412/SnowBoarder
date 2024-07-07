using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class VolumeSetting : MonoBehaviour
{
    [SerializeField] private AudioMixer myMixer;
    [SerializeField] private Slider musicSlider;
    [SerializeField] private Slider sfxSlider;

    private void Start()
    {
        if (PlayerPrefs.HasKey("musicVolume"))
        {
            LoadVolume();
        }
        else
        {
            SetMusicVolume();
            SetSFXVolume();
        }
    }
    public void SetMusicVolume()
    {
        float volumeMusic = musicSlider.value;


        myMixer.SetFloat("music", Mathf.Log10(volumeMusic) * 20);
        PlayerPrefs.SetFloat("musicVolume", volumeMusic);
    }

    public void SetSFXVolume()
    {
        float volumeSFX = sfxSlider.value;
        myMixer.SetFloat("sfx", Mathf.Log10(volumeSFX) * 20);
        PlayerPrefs.SetFloat("sfxVolume", volumeSFX);
    }

    private void LoadVolume()
    {
        musicSlider.value = PlayerPrefs.GetFloat("musicVolume");
        sfxSlider.value = PlayerPrefs.GetFloat("sfxVolume");

        SetMusicVolume();
        SetSFXVolume();
    }
}

