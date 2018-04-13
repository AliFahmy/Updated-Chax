using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserTurret : TurretsBuilding {

	public LaserTurret()
    {
        range = 15;
        attack = 100;
        attackSpeed = 10;
        cost = 100;
        Upgradecost = 200;
        level = 1;
    }
    public override void Shot()
    {
        //implement shoot func
    }
}
