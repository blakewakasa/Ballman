using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class OptionsMenu : MonoBehaviour {

    
    AudioSource audioSource;
    /*void Start()
    {
        audioSource = GetComponent<AudioSource>();

       
        audioSource.volume = PlayerPrefs.GetFloat("SliderVolumeLevel", audioSource.volume);
    }*/
    public void SetVolume(float volume)
    {
        AudioListener.volume = volume;
    }
}
