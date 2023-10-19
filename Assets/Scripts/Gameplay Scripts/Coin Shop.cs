using UnityEngine;
using UnityEngine.UI;

public class CoinShop : MonoBehaviour, IDataPersistance
{
    public Button coinShopButton; // Reference to the coin shop button
    public GameObject coinShopUI; // Reference to the coin shop UI
    public Button coinShopCloseButton; // Reference to the coin shop close button


    public void Start()
    {
        // Hide the coin shop UI by default.
        coinShopUI.SetActive(false);
    }

    // If the player clicks on the coinShopButton, display the coin shop UI.
    public void OpenCoinShop()
    {
        //Disable the coin shop button.
        coinShopButton.interactable = false;

        // Display the coin shop UI.
        coinShopUI.SetActive(true);

        //Enable the coin shop close button.
        coinShopCloseButton.interactable = true;
    }

    public void CloseCoinShop()
    {
        // Disable the coin shop close button.
        coinShopCloseButton.interactable = false;

        // Hide the coin shop UI.
        coinShopUI.SetActive(false);

        // Enable the coin shop button.
        coinShopButton.interactable = true;

    }

    public void LoadData(GameData data)
    {
        //If purchashed coin upgrades before, load the data.

       
    }

    public void SaveData(ref GameData data)
    {
        //Save the data for the coin upgrades.
    }
}
