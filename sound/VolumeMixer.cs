using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


//Permet de changer le volume du mixer a partir des slider du menu options
public class VolumeMixer : MonoBehaviour
{

    public AudioMixer mixer;
    public string mixername;

    public void SetVolume(float sliderValue)
    {
        mixer.SetFloat(mixername, Mathf.Log10(sliderValue) * 20);
    }
}
