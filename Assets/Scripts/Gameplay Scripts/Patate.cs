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

    }
}
