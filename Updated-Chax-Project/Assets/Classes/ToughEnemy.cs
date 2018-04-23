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
    }
    public ToughEnemy(int l)
    {
        Level = l;
       CurrentSpeed = Speed = 3;
        Health = MainHealth = Level * 1000f;
        KillReward = Level * 15;
    }
    
}
