using UnityEngine;
using UnityEngine.Audio;

public class MusicVolume : MonoBehaviour
{
  
    public AudioMixer MusicVolumeMixer;

    public void SetLevel(float sliderValue)
    {
        MusicVolumeMixer.SetFloat("MusicVolumeMixer", Mathf.Log10(sliderValue) * 20);
    }

    //If the player clicks on a music toggle button, set the music volume to 0.
    public void SetMusicVolumeToZero()
    {
        MusicVolumeMixer.SetFloat("MusicVolumeMixer", Mathf.Log10(0) * 20);
    }

    //If the player clicks on a music toggle button again, set the music volume to the sliders value.
    public void SetMusicVolumeToSliderValue(float sliderValue)
    {
        MusicVolumeMixer.SetFloat("MusicVolumeMixer", Mathf.Log10(sliderValue) * 20);
    }
    
   

}
