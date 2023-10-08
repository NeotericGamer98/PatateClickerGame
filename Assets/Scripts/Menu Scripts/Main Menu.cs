using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Load Primary Game Scene upon PLAY button click. 
    public void LOAD_PRIMARY_GAME_SCENE() {
        SceneManager.LoadScene("Primary Game");

    }

    //Load Options Scene upon OPTIONS button click. 
    public void LOAD_OPTIONS_MENU()
    {
        SceneManager.LoadScene("Options Menu");

    }

    //Quit Patate Clicker Game.
    public void QUIT_GAME()
    {
        Application.Quit();
    }
}
