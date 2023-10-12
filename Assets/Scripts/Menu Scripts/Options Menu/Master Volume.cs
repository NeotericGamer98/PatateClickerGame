using UnityEngine;
using UnityEngine.Audio;

public class MasterVolume : MonoBehaviour
{

    public AudioMixer MasterVolumeMixer;

    public void SetLevel(float sliderValue)
    {
        MasterVolumeMixer.SetFloat("MasterVolumeMixer", Mathf.Log10(sliderValue) * 20);
    }
 
}
