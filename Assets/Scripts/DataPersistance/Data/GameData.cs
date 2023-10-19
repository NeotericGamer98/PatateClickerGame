using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData 
{

    public int patateCoins;
    public int patateCoinsPerClick;
    public int patateCoinsPerSecond;
    public int patateCoinsPerClickUpgradeCost;
    public int patateCoinsPerSecondUpgradeCost;
    public int patateCoinsPerClickUpgradeLevel;
    public int patateCoinsPerSecondUpgradeLevel;
    public int patateCoinsPerClickUpgradeCostMultiplier;
    public int patateCoinsPerSecondUpgradeCostMultiplier;
    public int patateCoinsPerClickUpgradeCostBase;
    public int patateCoinsPerSecondUpgradeCostBase;
    
    //The values defined in the constructor are the default values the game starts with when there is no data to load.
    public GameData()
    {
        patateCoins = 0;
        patateCoinsPerClick = 1;
        patateCoinsPerSecond = 0;
        patateCoinsPerClickUpgradeCost = 10;
        patateCoinsPerSecondUpgradeCost = 10;
        patateCoinsPerClickUpgradeLevel = 1;
        patateCoinsPerSecondUpgradeLevel = 1;
        patateCoinsPerClickUpgradeCostMultiplier = 2;
        patateCoinsPerSecondUpgradeCostMultiplier = 2;
        patateCoinsPerClickUpgradeCostBase = 10;
        patateCoinsPerSecondUpgradeCostBase = 10;
    }

}
