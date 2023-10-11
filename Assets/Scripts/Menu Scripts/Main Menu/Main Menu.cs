using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {

        // Animate the Game Title text to pulse in and out.
        GameObject.Find("Game Title").transform.localScale = new Vector3(1 + Mathf.PingPong(Time.time / 2, 0.1f), 1 + Mathf.PingPong(Time.time / 2, 0.1f), 1);

    }

    //Load Primary Game Scene upon PLAY button click and play a sound.
    public void LOAD_GAME()
    {
        SceneManager.LoadScene("Primary Game");

    }


    //Load Options Scene upon OPTIONS button click. 
    public void LOAD_OPTIONS_MENU()
    {
        SceneManager.LoadScene("Options Menu");

    }

    //Close the application and exit to the host operating system when the quit button is clicked.
    public void QUIT_GAME()
    {
        Application.Quit();
    }

    //If the players hits the escape key, the game will quit.
    private void OnGUI()
    {
        if (Event.current.Equals(Event.KeyboardEvent("escape")))
        {
            Application.Quit();
        }
    }

    //If the player clicks on the Game Version text, send them to the GitHub page for the game.
    public void OPEN_GITHUB()
    {
        Application.OpenURL("https://github.com/NeotericGamer98/PatateClickerGame");
    }


}
