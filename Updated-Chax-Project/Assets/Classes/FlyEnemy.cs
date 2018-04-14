using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyEnemy : Enemy
{
    public FlyEnemy()
    {
        Level = 1;
        Speed = Level ;
        Health = Level * 100;
        KillReward = Level * 50;
    }
    public FlyEnemy(int l)
    {
        Level = l;
        Speed = Level ;
        Health = Level * 100;
        KillReward = Level * 50;
    }

}
