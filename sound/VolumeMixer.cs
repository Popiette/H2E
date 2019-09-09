using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

namespace hydroger.sound
{

    // Change sound volume with sliders of options menu.
    public class VolumeMixer : MonoBehaviour
    {

        public AudioMixer mixer;
        public string mixername;

        public void SetVolume(float sliderValue)
        {
            mixer.SetFloat(mixername, Mathf.Log10(sliderValue) * 20);
        }
    }

}