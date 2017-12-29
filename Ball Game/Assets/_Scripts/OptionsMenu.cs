using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class OptionsMenu : MonoBehaviour {

    
    AudioSource audioSource;
    public static float uniVolume = -30;
    /*void Start()
    {
        audioSource = GetComponent<AudioSource>();

       
        audioSource.volume = PlayerPrefs.GetFloat("SliderVolumeLevel", audioSource.volume);
    }*/
    public void SetVolume(float volume)
    {
        if (uniVolume !=-30)
        {
            AudioListener.volume = uniVolume;
        }
        else
        {
            AudioListener.volume = volume;
        }
        
    }
}
