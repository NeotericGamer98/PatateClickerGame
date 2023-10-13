using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CoreGameplay : MonoBehaviour
{

    //Create a public Quick Settings UI GameObject.
    public GameObject quickSettingsUI;

    // Start is called before the first frame update
    void Start()
    {
        //Check if this is a new game. If it is, reset the Patate Coins to 0.
        if (PlayerPrefs.GetInt("New Game") == 1)
        {
            PlayerPrefs.SetInt("Patate Coins", 0);
        }

        //If this is a new game, reset the player level to 1.
        if (PlayerPrefs.GetInt("New Game") == 1)
        {
            PlayerPrefs.SetInt("Player Level", 1);
        }

        //If this is a new game, reset all purchased Patate Coin and Patate Upgrades to 0.
        if (PlayerPrefs.GetInt("New Game") == 1)
        {
            PlayerPrefs.SetInt("Patate Coin Upgrades", 0);
            PlayerPrefs.SetInt("Patate Upgrades", 0);
        }

        //If this is a new game, reset the Patate sprite to the default sprite.
        if (PlayerPrefs.GetInt("New Game") == 1)
        {
            PlayerPrefs.SetInt("Patate Sprite", 0);
        }

        //If this is not a new game, load the player's save file.
        if (PlayerPrefs.GetInt("New Game") == 0)
        {
            //Load the player's save file.
            PlayerPrefs.SetInt("Patate Coins", PlayerPrefs.GetInt("Patate Coins"));
            PlayerPrefs.SetInt("Player Level", PlayerPrefs.GetInt("Player Level"));
            PlayerPrefs.SetInt("Patate Coin Upgrades", PlayerPrefs.GetInt("Patate Coin Upgrades"));
            PlayerPrefs.SetInt("Patate Upgrades", PlayerPrefs.GetInt("Patate Upgrades"));
            PlayerPrefs.SetInt("Patate Sprite", PlayerPrefs.GetInt("Patate Sprite"));
            PlayerPrefs.SetFloat("Patate Scale", PlayerPrefs.GetFloat("Patate Scale"));
            PlayerPrefs.SetFloat("Patate Position X", PlayerPrefs.GetFloat("Patate Position X"));
            PlayerPrefs.SetFloat("Patate Position Y", PlayerPrefs.GetFloat("Patate Position Y"));
        }


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


    //If the player clicks on the Globe icon, display the player's globalleaderboard ranking.
    public void OpenGlobalLeaderboard()
    {
        Application.OpenURL("https://neotericgamer98.github.io/PatateClickerGame/");
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

   
}
