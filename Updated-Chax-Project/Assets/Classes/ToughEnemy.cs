using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToughEnemy : GroundEnemy
{
    public ToughEnemy()
    {
        Level = 1;
       CurrentSpeed = Speed = 3;
        Health = MainHealth= Level * 1000f;
        KillReward = Level * 15;
        Score = Level * 50;
    }
    public ToughEnemy(int l)
    {
        Level = l;
        Score = Level * 50;
        CurrentSpeed = Speed = 3;
        Health = MainHealth = Level * 1000f;
        KillReward = Level * 15;
    }
    
}
