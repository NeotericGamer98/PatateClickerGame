using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;
using TMPro;
using UnityEngine.Animations;

public class Patate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Have the Patate Sprite follow the mouse.
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(mousePos.x, mousePos.y, 0);

        //If the player clicks on the 2D Patate Sprite, have the Patate Sprite pulse once for every click.
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<Animator>().SetTrigger("Pulse");
        }
        
        //For every player click of the Patate Sprite, add 1 Patate Coin.
        if (Input.GetMouseButtonDown(0))
        {
            PlayerPrefs.SetInt("Patate Coins", PlayerPrefs.GetInt("Patate Coins") + 1);
        }
        
    }
}
