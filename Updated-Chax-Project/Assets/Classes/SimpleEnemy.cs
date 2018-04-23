using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleEnemy : Enemy {

    public SimpleEnemy()
    {
        Level = 1;
       CurrentSpeed= Speed = 10;
        Health = MainHealth = Level * 200;
        KillReward = Level * 5;
    }
    public SimpleEnemy(int l)
    {
        Level = l;
       CurrentSpeed = Speed =  5;
        Health = MainHealth = Level * 200;
        KillReward = Level * 5;
    }
}
