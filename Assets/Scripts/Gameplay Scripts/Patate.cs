using UnityEngine;

public class Patate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Reset Patate position on screen upon loading the scene.
        transform.SetPositionAndRotation(new Vector3(0, 0, 0), Quaternion.identity);
        transform.localScale = Vector3.one;


    }

    // Update is called once per frame
    void Update()
    {

        //For every player click of the Patate Sprite, add 1 Patate Coin.
        if (Input.GetMouseButtonDown(0))
        {
            PlayerPrefs.SetInt("Patate Coins", PlayerPrefs.GetInt("Patate Coins") + 1);
        }

        //If Patate sprite clicked, bounce back.
        if (Input.GetMouseButtonDown(0))
        {
            //Smoothly shrink the sprite when clicked.
            transform.localScale = Vector3.Lerp(transform.localScale, Vector3.one * 0.9f, 0.5f);
            
        }
        else if (Input.GetMouseButtonUp(0))
        {
            //Smoothly return the sprite to its original size.
            transform.localScale = Vector3.Lerp(transform.localScale, Vector3.one, 1f);
            
        }

        
    }
}
