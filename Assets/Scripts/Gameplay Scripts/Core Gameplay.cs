using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;
using TMPro;

public class CoreGameplay : MonoBehaviour
{
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
        //After 100 Patate Sprite clicks, increase the player's level by 1.
        if (PlayerPrefs.GetInt("Patate Coins") >= 100)
        {
            PlayerPrefs.SetInt("Player Level", PlayerPrefs.GetInt("Player Level") + 1);
            PlayerPrefs.SetInt("Patate Coins", 0);
        }
        

    }

    //Return to main menu if Main Menu button is pressed.
    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

}
