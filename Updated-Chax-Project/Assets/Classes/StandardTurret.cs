using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandardTurret : TurretsBuilding {

    public StandardTurret()
    {
        range = 15;
        attack = 30;
        attackSpeed = 1;
        cost = 50;
        Upgradecost = 150;
        level = 1;
        RotationSpeed = 10;
    }
}
