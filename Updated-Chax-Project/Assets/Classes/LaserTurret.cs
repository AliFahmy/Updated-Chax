using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserTurret : TurretsBuilding {

	public LaserTurret()
    {
        range = 15;
        attack = 6;
        attackSpeed = 10;
        cost = 300;
        Upgradecost = 450;
        level = 1;
    }
	public override void UpgradeTurret ()
	{
		level++;
		range += 1;
		attack += 3;
		UpgradeCost *= 2;

	}
}
