using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TurretsBuilding : Buildings
{
    private int Level;
    private int UpgradeCost;
    private int Cost;
    public int level
    {
        get
        {
            return Level;
        }
        set
        {
            Level = value;
        }
    }
    public int Upgradecost
    {
        get
        {
            return UpgradeCost;
        }
        set
        {
            UpgradeCost = value;
        }
    }
    public int cost
    {
        get
        {
            return Cost;
        }
        set
        {
            Cost = value;
        }
    }
    public  TurretsBuilding()
    {
        Level = 0;
        UpgradeCost = 0;
        Cost = 0;
    }
    public void IncreaseLevel()
    {
        Level++;
        attackSpeed *= 2;
        attack *= 2;
    }
}
