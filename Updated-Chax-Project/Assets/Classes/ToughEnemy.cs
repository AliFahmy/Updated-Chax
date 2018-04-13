using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToughEnemy : GroundEnemy
{
    public ToughEnemy()
    {
        Level = 1;
        Speed = Level * 2;
        Health = Level * 1000;
        KillReward = Level * 150;
    }
    public ToughEnemy(int l)
    {
        Level = l;
        Speed = Level * 2;
        Health = Level * 1000;
        KillReward = Level * 150;
    }
    public override void move()
    {
        //implement 
    }
}
