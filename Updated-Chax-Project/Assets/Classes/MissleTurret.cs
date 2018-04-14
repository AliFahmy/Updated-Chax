using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissleTurret : TurretsBuilding {

    public MissleTurret()
    {
        range = 10;
        attack = 200;
        attackSpeed = 2;
        cost = 150;
        Upgradecost = 350;
        level = 1;
    }
 
}
