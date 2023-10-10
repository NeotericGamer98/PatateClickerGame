using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class OptionsMenu : MonoBehaviour
{
    //Return to main menu if return button is pressed.
    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

}
