using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;

public class OptionsMenu : DataPersistanceManager
{

    public AudioMixer MasterVolumeMixer;
    public AudioMixer MusicVolumeMixer;
    public AudioMixer SFXVolumeMixer;
    public Slider MusicVolumeSlider;
    public Slider MasterVolumeSlider;
    public TextMeshProUGUI OptionsMenuTitle;
    public Toggle WindowedModeToggle;
    public GameObject OptionsMenuUI;
    public GameObject ResetGameDataUI;
    public Button ResetGameDataButton;
    public Button ResetButton;
    public Button CancelButton;
    public TextMeshProUGUI ResetGameDataUIText;
    public AudioClip ResetGameDataAudio;

    // Start is called before the first frame update
    void Start()
    {
        //Disable the Reset Game Data UI by default.
        ResetGameDataUI.SetActive(false);
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

    //If the player clicks on the reset game data button, display the reset game data UI.
    public void OpenResetGameDataUI()
    {
        //Disable the options menu UI.
        OptionsMenuUI.SetActive(false);

        //Disable the reset game data button.
        ResetGameDataButton.interactable = false;

        //Play the reset game data audio clip.
        AudioSource.PlayClipAtPoint(ResetGameDataAudio, transform.position);
    
        //Set the Game Data UI Text to be blank.
        ResetGameDataUIText.GetComponentInChildren<TextMeshProUGUI>().text = "";

        //Enable the reset game data button.
        ResetGameDataButton.interactable = true;

        //Display the reset game data UI.
        ResetGameDataUI.SetActive(true);
    }

    //If the player clicks on the reset game data button, reset the game data.
    public void ResetGameData()
    {
        //Reset the game data.
        base.ResetGameData();

        //Display a message in the console to confirm that the game data has been reset.
        Debug.Log("Game data has been reset.");

        //Update Game Data UI Text to say that the game data has been reset.
        ResetGameDataUIText.GetComponentInChildren<TextMeshProUGUI>().text = "Game data has been reset.";

        //Set the Game Data UI Text to be blank.
        ResetGameDataUIText.GetComponentInChildren<TextMeshProUGUI>().text = "";

        //Disable the reset game data button.
        ResetGameDataButton.interactable = false;

        //Disable the reset game data UI.
        ResetGameDataUI.SetActive(false);

        //Enable the options menu UI.
        OptionsMenuUI.SetActive(true);
    }

    //If the player clicks on the cancel button, close the reset game data UI.
    public void CloseResetGameDataUI()
    {
        //Enable the options menu UI.
        OptionsMenuUI.SetActive(true);

        //Enable the reset game data button.
        ResetGameDataButton.interactable = true;

        //Close the reset game data UI.
        ResetGameDataUI.SetActive(false);
    }

    //If the player clicks on the windowed mode toggle button, set the game to windowed mode.
    public void SetWindowedMode()
    {
        Screen.fullScreen = false;
    }

    //If the player clicks on the fullscreen mode toggle button, set the game to fullscreen mode.
    public void SetFullscreenMode()
    {
        Screen.fullScreen = true;
    }
}
