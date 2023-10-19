using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MusicVolume : MonoBehaviour
{
  
    public AudioMixer MusicVolumeMixer;
    public Button MusicToggleButton;

    //If the player clicks on a music toggle button, set the music volume to 0.
    public void SetMusicVolumeToZero()
    {
        //Mute the music.
        MusicVolumeMixer.SetFloat("MusicVolume", -80.0f);
      
    }

    //If the player clicks on a music toggle button again, set the music volume to the sliders value.
    public void SetMusicVolumeToSliderValue(float sliderValue)
    {
        //Unmute the music.
        MusicVolumeMixer.SetFloat("MusicVolume", sliderValue);    
    }
    
   

}
