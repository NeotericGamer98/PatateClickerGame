using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class PatateCoins : MonoBehaviour
{
    //Create a public float variable to store the player's Patate Coins value.
    public float patatecoins;

    //Coin collection sound effect.
    public AudioClip coinCollection;

    //Create a public TextMeshProUGUI variable to store the Patate Coins text.
    public TextMeshProUGUI PatateCoinsText;

    //Create a public patate coin icon image.
    public GameObject patateCoinIcon;

    //Create a public Patate object.
    public GameObject Patate;

    // Update is called once per frame
    void Update()
    {
        //Set the Patate Coins text to the player's Patate Coins value.
        PatateCoinsText.text = PlayerPrefs.GetInt("Patate Coins").ToString();

        //Only if the player clicks on the Patate Sprite, bounce the Patate Coins Icon.
        if (Input.GetMouseButtonDown(0))
        {
            //Create a Raycast to detect if the player clicked on the Patate Sprite.
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            //If the player clicked on the Patate Sprite, bounce the Patate Coins Icon.
            if (hit.collider != null && hit.collider.gameObject.name == "Patate")
            {
                //Play the coin collection sound effect.
                GetComponent<AudioSource>().PlayOneShot(coinCollection);

                //Depress the Patate Coins Icon.
                patateCoinIcon.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);

                //Un-depress the Patate Coins Icon.
                patateCoinIcon.transform.localScale = new Vector3(1f, 1f, 1f);


            }
        }

    }
       
}
