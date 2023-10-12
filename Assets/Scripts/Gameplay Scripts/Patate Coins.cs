using UnityEngine;
using TMPro;
using UnityEngine.Audio;

public class PatateCoins : MonoBehaviour
{
    //Create a public float variable to store the player's Patate Coins value.
    public float patatecoins;

    //Coin collection sound effect.
    public AudioClip coinCollection;

    //Create a public TextMeshProUGUI variable to store the Patate Coins text.
    public TextMeshProUGUI PatateCoinsText;

    // Update is called once per frame
    void Update()
    {
        //Set the Patate Coins text to the player's Patate Coins value.
        PatateCoinsText.text = PlayerPrefs.GetInt("Patate Coins").ToString();

        //Organize the Patate Coins value to be displayed dynamically based on the player's Patate Coins value.
        if (patatecoins >= 1000000000)
        {
            PatateCoinsText.text = (patatecoins / 1000000000).ToString("F0") + "B";
        }
        else if (patatecoins >= 1000000)
        {
            PatateCoinsText.text = (patatecoins / 1000000).ToString("F0") + "M";
        }
        else if (patatecoins >= 1000)
        {
            PatateCoinsText.text = (patatecoins / 1000).ToString("F0") + "K";
        }

        //For every coin collectd by clicking the Patate Sprite, play the coin collection sound effect.
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<AudioSource>().PlayOneShot(coinCollection);
        }
      


    }
       
}
