using UnityEngine;

public class PatateCoins : MonoBehaviour
{
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
        //Constantly check and update Patate Coins Text with the current ammount of patate coins.
        GetComponent<TextMesh>().text = PlayerPrefs.GetInt("Patate Coins").ToString();
        

    }
}
