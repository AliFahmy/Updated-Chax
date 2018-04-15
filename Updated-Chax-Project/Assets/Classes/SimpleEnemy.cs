using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleEnemy : Enemy {

    public SimpleEnemy()
    {
        Level = 1;
        Speed = 5;
        Health = Level * 100;
        KillReward = Level * 50;
    }
    public SimpleEnemy(int l)
    {
        Level = l;
        Speed =  5;
        Health = Level * 100;
        KillReward = Level * 50;
    }
}
