using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissleTurret : TurretsBuilding {

    public MissleTurret()
    {
        RotationSpeed = 20;
        range = 30f;
        attack = 200;
        attackSpeed = 0.25f;
        cost = 150;
        Upgradecost = 225;
        level = 1;
    }
	public override void UpgradeTurret ()
	{
		level++;
		range += 1;
		attack += 100;
		UpgradeCost += 75;
		cost = UpgradeCost;
	}
}
