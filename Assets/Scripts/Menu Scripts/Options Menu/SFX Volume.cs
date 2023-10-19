using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SFXVolume : MonoBehaviour
{

    // Reference to the SFX Audio Mixer.
    public AudioMixer SFXVolumeMixer;

    //Reference the SFX toggle button.
    public Button SFXToggleButton;

    //If the player clicks on the SFX toggle button, mute or unmute the SFX.
    public void ToggleSFX(bool SFXToggleButton)
    {
        //If the player clicks on the SFX toggle button, mute or unmute the SFX.
        if (SFXToggleButton)
        {
            //Unmute the SFX.
            SFXVolumeMixer.SetFloat("SFXVolume", 0.0f);
        }
        else
        {
            //Mute the SFX.
            SFXVolumeMixer.SetFloat("SFXVolume", -80.0f);
        }
    }
}
