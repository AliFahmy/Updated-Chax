using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyEnemy : Enemy
{
    public FlyEnemy()
    {
        Level = 1;
       CurrentSpeed = Speed = 5 ;
        Health = MainHealth = 300f;
        KillReward = Level * 10;
    }
    public FlyEnemy(int l)
    {
        Level = l;
       CurrentSpeed = Speed = 5 ;
        Health = MainHealth = Level * 300f;
        KillReward = Level * 10;
    }

}
