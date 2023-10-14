using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;

public class OptionsMenu : MonoBehaviour
{

    public AudioMixer MasterVolumeMixer;
    public AudioMixer MusicVolumeMixer;
    public AudioMixer SFXVolumeMixer;
    public Slider MusicVolumeSlider;
    public Slider MasterVolumeSlider;
    public TextMeshProUGUI OptionsMenuTitle;
    public Toggle WindowedModeToggle;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //Gently fade the title in.
        OptionsMenuTitle.color = new Color(OptionsMenuTitle.color.r, OptionsMenuTitle.color.g, OptionsMenuTitle.color.b, Mathf.PingPong(Time.time, 1));


        //Set the music volume to the slider value.
        MusicVolumeMixer.SetFloat("MusicVolumeMixer", Mathf.Log10(MusicVolumeSlider.value) * 20);

        //Set the master volume to the slider value.
        MasterVolumeMixer.SetFloat("MasterVolumeMixer", Mathf.Log10(MasterVolumeSlider.value) * 20);


        
    }

    //Return to main menu if return button is pressed.
    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    //If the player clicks on the windowed mode toggle button, set the game to windowed mode.
    public void SetWindowedMode()
    {
        Screen.fullScreen = false;
    }

}
