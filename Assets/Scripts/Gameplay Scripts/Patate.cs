using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Patate : MonoBehaviour
{
 
    //Get the current patate sprite from the sprte array.
    public Sprite[] patateSprites;
   
    //Create a public patate sprite click value.
    public int patateSpriteClickValue;

    // Start is called before the first frame update
    void Start()
    {
       
        //Get the current patate sprite click value.
        patateSpriteClickValue = PlayerPrefs.GetInt("Patate Sprite Click Value");

        //Set the patate sprite click value to 1 if it is 0.
        if (patateSpriteClickValue == 0)
        {
            patateSpriteClickValue = 1;
        }

    }

    // Update is called once per frame
    void Update()
    {

        //If the player clicks on the patate sprite, add the patate sprite click value to the player's patate coins.
        if (Input.GetMouseButtonDown(0))
        {
            //Create a Raycast to detect if the player clicked on the patate sprite.
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            //If the player clicked on the patate sprite, add the patate sprite click value to the player's patate coins.
            if (hit.collider != null && hit.collider.gameObject.name == "Patate")
            {
                //Add the patate sprite click value to the player's patate coins.
                PlayerPrefs.SetInt("Patate Coins", PlayerPrefs.GetInt("Patate Coins") + patateSpriteClickValue);

            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            // Create a Raycast to detect if the player clicked on the Patate Sprite.
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            // If the player clicked on the Patate Sprite, bounce the Patate.
            if (hit.collider != null && hit.collider.gameObject.name == "Patate")
            {
                // Get the transform of the Patate object.
                Transform patateTransform = hit.collider.gameObject.transform;

                // Depress the Patate.
                patateTransform.localScale = new Vector3(0.5f, 0.5f, 0.5f);

                // Un-depress the Patate after a short delay (you can adjust the delay as needed).
                StartCoroutine(UnDepressPatate(patateTransform));
            }
        }

        // Coroutine to un-depress the Patate after a short delay.
        static IEnumerator UnDepressPatate(Transform patateTransform)
        {
            yield return new WaitForSeconds(0.1f); // Adjust the delay as needed.
            patateTransform.localScale = new Vector3(1f, 1f, 1f);
        }


    }
}
