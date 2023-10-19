using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CoreGameplay: MonoBehaviour, IDataPersistance
{

    //Create a public Quick Settings UI GameObject.
    public GameObject quickSettingsUI;

    //Create a public GameplayMusic GameObject.
    public GameObject gameplayMusic;

    public void LoadData(GameData data)
    {

    }

    public void SaveData(ref GameData data)
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        //Ensure the Quick Settings UI is not displayed.
        quickSettingsUI.SetActive(false);

        //Ensure the Gameplay Music is not playing.
        gameplayMusic.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Return to Main Menu if Main Menu button is pressed.
    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    //If the player clicks on the Quick Settings icon, display the Quick Settings UI.
    public void OpenQuickSettings()
    {
        //Display the Quick Settings UI.
        quickSettingsUI.SetActive(true);
    }

    //If the player clicks on the Close Quick Settings button, close the Quick Settings UI.
    public void CloseQuickSettings()
    {
        //Close the Quick Settings UI.
        quickSettingsUI.SetActive(false);
    }

    //Enable the Gameplay Music.
    public void EnableGameplayMusic()
    {
        //Enable the Gameplay Music.
        gameplayMusic.SetActive(true);
        
    }

}
