using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Settings : MonoBehaviour {

    public AudioMixer AudioMixer;

    public void SetVolume(float volume)
    {
        Debug.Log("Volume");
        AudioMixer.SetFloat("Volume", volume);
    }
	
    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void SetFullscreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }
}
