using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TurretsBuilding : Buildings
{
    protected float rotationSpeed;
	protected int Level;
	protected int UpgradeCost;
	protected int Cost;
    public float RotationSpeed
    {
        get
        {
            return rotationSpeed;
        }
        set
        {
            rotationSpeed = value;
        }
    }
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
        rotationSpeed = 20;
        Level = 0;
        UpgradeCost = 0;
        Cost = 0;
    }
	public virtual void UpgradeTurret()
    {
        Level++;
        attackSpeed *= 2;
        attack *= 2;
        UpgradeCost *= 2;
    }
}
