using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleEnemy : GroundEnemy {

    public SimpleEnemy()
    {
        Level = 1;
       CurrentSpeed= Speed = 10;
        Score = Level * 5;
        Health = MainHealth = Level * 200;
        KillReward = Level * 5;
    }
    public SimpleEnemy(int l)
    {
        Level = l;
        Score = Level * 5;
        CurrentSpeed = Speed =  5;
        Health = MainHealth = Level * 200;
        KillReward = Level * 5;
    }
}
