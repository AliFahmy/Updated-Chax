using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyEnemy : Enemy
{
    public FlyEnemy()
    {
        Level = 1;
        Speed = 5 ;
        Health = MainHealth = 300;
        KillReward = Level * 10;
    }
    public FlyEnemy(int l)
    {
        Level = l;
        Speed = 5 ;
        Health = MainHealth = Level * 300;
        KillReward = Level * 10;
    }

}
