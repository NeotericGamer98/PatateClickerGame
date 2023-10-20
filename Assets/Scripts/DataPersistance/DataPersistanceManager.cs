using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class DataPersistanceManager: MonoBehaviour
{
    [Header("File Storage Configuration")]
    [SerializeField] private string fileName;


    private GameData gameData;

    private List<IDataPersistance> dataPersistanceObjects = new List<IDataPersistance>();

    private FileDataHandler dataHandler;
    public static DataPersistanceManager instance { get; private set; }

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("There is more than one DataPersistanceManager in the scene.");
        }
        instance = this;

        // Initialize the data handler in Awake to ensure it's ready.
        this.dataHandler = new FileDataHandler(Application.persistentDataPath, fileName);
    }

    private void Start()
    {
        this.dataPersistanceObjects = FindAllDataPersistanceObjects();
        LoadGame();
    }

    public void NewGame(GameData gameData) { 
        this.gameData = new GameData();
    }

    public void LoadGame() { 

        //Load any saved data from a file using the data handler.
        this.gameData = dataHandler.Load();

        //If no data can be loaded, initialize to a new game.
        if (this.gameData == null)
        {
            Debug.Log("No game data found. Initializing data to defaults.");
            NewGame(gameData);
        }
        //Push the loaded data to all other scripts that need it.
        foreach (IDataPersistance dataPersistanceObj in dataPersistanceObjects)
        {
            dataPersistanceObj.LoadData(gameData);
        }
    }

    
    public void SaveGame()
    {
        //Pass the data to other scripts so they can update it.
        foreach (IDataPersistance dataPersistanceObj in dataPersistanceObjects)
        {
            dataPersistanceObj.SaveData(ref gameData);
        }

        //Save that data to a file using the data handler.
        dataHandler.Save(gameData);
    
    }

    //This method is called when the application is closed.
    private void OnApplicationQuit()
    {
        SaveGame();
    }

    //This method is called when the reset game data button is pressed.
    public void ResetGameData()
    {
        //Initialize the game data to a new game.
        NewGame(gameData);
    }

    private List<IDataPersistance> FindAllDataPersistanceObjects()
    {
        IEnumerable<IDataPersistance> dataPersistanceObjects = FindObjectsOfType<MonoBehaviour>().OfType<IDataPersistance>();
        return new List<IDataPersistance>(dataPersistanceObjects);
    }

}
