using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public TextMeshProUGUI GameTitle; // Reference to the TextMeshPro component for the game title
    private int clickCounter = 0; // Counter for the number of clicks
    private const int requiredClicks = 10; // Number of clicks required for the secret message


    // Update is called once per frame
    void Update()
    {

        // Animate the Game Title text to pulse in and out.
        GameObject.Find("GameTitle").transform.localScale = new Vector3(1 + Mathf.PingPong(Time.time / 2, 0.1f), 1 + Mathf.PingPong(Time.time / 2, 0.1f), 1);

        //Also animate the Game Title text to wobble in and out.
        GameObject.Find("GameTitle").transform.rotation = Quaternion.Euler(0, 0, 5 * Mathf.Sin(Time.time * 2));

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

    //Load Credits Scene upon CREDITS button click.
    public void LOAD_CREDITS_MENU()
    {
        SceneManager.LoadScene("Credits Scene");

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

    //If the player clicks on the Game Title text enough times, display a secret message.
    public void SECRET_MESSAGE()
    {
        // Check if the player has clicked on the Game Title enough times
        if (clickCounter != requiredClicks)
        {
            clickCounter++; // Increment the click counter

            if (clickCounter == requiredClicks)
            {
                // If the player has clicked the required number of times, display the secret message
                GameTitle.text = "You found the easter egg!";

            }
        }
        else
        {
            // If the player has already found the easter egg, reset the text to the default
            GameTitle.text = "Patate Clicker";
            //Reset the click counter
            clickCounter = 0;

        }
    }



}
