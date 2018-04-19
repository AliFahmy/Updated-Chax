using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToughEnemy : GroundEnemy
{
    public ToughEnemy()
    {
        Level = 1;
        Speed = 3;
        Health = Level * 1000;
        KillReward = Level * 15;
    }
    public ToughEnemy(int l)
    {
        Level = l;
        Speed = 3;
        Health = Level * 1000;
        KillReward = Level * 15;
    }
    public override void move()
    {
        //implement 
    }
}
