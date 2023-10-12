using UnityEngine;
using UnityEngine.Audio;

public class MusicVolume : MonoBehaviour
{
  
    public AudioMixer MusicVolumeMixer;

    public void SetLevel(float sliderValue)
    {
        MusicVolumeMixer.SetFloat("MusicVolumeMixer", Mathf.Log10(sliderValue) * 20);
    }

}
