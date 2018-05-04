using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseBuilding : Buildings {

	protected int MainHealth;
	protected int CurrentHealth;
	protected int RepairCost;
    public int repairCost
    {
        get
        {
            return RepairCost;
        }
        set
        {
            RepairCost = value;
        }
    }

    public int currentHealth
    {
        get
        {
            return CurrentHealth;
        }
        set
        {
            CurrentHealth = value;
        }
    }
    public int mainHealth
    {
        get
        {
            return MainHealth;
        }
        set
        {
            MainHealth = value;
        }
    }

    public BaseBuilding()
    {
        MainHealth = CurrentHealth=0;
        RepairCost = 0;
    }
    public BaseBuilding(int H )
    {
        MainHealth = CurrentHealth = H;
        RepairCost = 0;
    }
    public void Repair()
    {
        CurrentHealth = MainHealth;

    }
}
