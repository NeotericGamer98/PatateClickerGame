using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Load the Main Menu scene when the RETURN button is clicked. 
    public void LOAD_MAIN_MENU()
    {
        SceneManager.LoadScene("Main Menu");

    }

    //Apply the user's seleced game option settings once the Apply Settings button is clicked.
    public void APPLY_GAME_SETTINGS() { 
    
    
    }
}
