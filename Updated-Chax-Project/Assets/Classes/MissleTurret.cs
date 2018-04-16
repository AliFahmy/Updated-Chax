using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissleTurret : TurretsBuilding {

    public MissleTurret()
    {
        range = 30f;
        attack = 200;
        attackSpeed = 0.25f;
        cost = 150;
        Upgradecost = 350;
        level = 1;
    }
 
}
