using UnityEngine;

public class PatateCoins : MonoBehaviour
{
    //Create a public variable to store the player's Patate Coins.
    public int patatecoins = 0;

    public PatateCoins(int patateCoins)
    {
        patatecoins = patateCoins;
    }

    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("Patate Coins");

        //Reset Patate Coins to 0 if this is a new game.
        if (PlayerPrefs.GetInt("New Game") == 1)
        {
            PlayerPrefs.SetInt("Patate Coins", 0);
        }
        

    }

    // Update is called once per frame
    void Update()
    {

        //Display the player's current Patate Coins.
        Debug.Log("Patate Coins: " + PlayerPrefs.GetInt("Patate Coins"));
        
       

    }
}
