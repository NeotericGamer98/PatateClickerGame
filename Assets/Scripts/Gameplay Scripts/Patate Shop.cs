using UnityEngine;
using UnityEngine.UI;

public class PatateShop : MonoBehaviour, IDataPersistance
{
    public Button patateShopButton; // Reference to the patate shop button
    public GameObject patateShopUI; // Reference to the patate shop UI
    public Button patateShopCloseButton; // Reference to the patate shop close button

    public void LoadData(GameData data)
    {

        //If purchashed patate shop upgrades before, load the data.
       
    }

    public void SaveData(ref GameData data)
    {

        //Save the data for the patate shop upgrades.
       
    }

    // Start is called before the first frame update
    void Start()
    {
        // Hide the patate shop UI by default.
        patateShopUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    // If the player clicks on the patateShopButton, display the patate shop UI.
    public void OpenPatateShop()
    {
        //Disable the patate shop button.
        patateShopButton.interactable = false;

        // Display the patate shop UI.
        patateShopUI.SetActive(true);
   
        //Enable the patate shop close button.
        patateShopCloseButton.interactable = true;
    }

    // If the player clicks on the patateShopCloseButton, hide the patate shop UI.
    public void ClosePatateShop()
    {
        // Disable the patate shop close button.
        patateShopCloseButton.interactable = false;

        // Hide the patate shop UI.
        patateShopUI.SetActive(false);

        // Enable the patate shop button.
        patateShopButton.interactable = true;

    }
}
