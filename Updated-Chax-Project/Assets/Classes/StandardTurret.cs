using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandardTurret : TurretsBuilding {

    public StandardTurret()
    {
        range = 15;
        attack = 30;
        attackSpeed = 1.0f;
        cost = 50;
        Upgradecost = 75;
        level = 1;
        RotationSpeed = 10;
    }
	public override void UpgradeTurret ()
	{
		level++;
		range += 1;
		attack += 15;
		UpgradeCost += 25;
		cost = UpgradeCost;

	}
}
