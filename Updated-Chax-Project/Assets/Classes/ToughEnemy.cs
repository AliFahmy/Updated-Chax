using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToughEnemy : GroundEnemy
{
    public ToughEnemy()
    {
        Level = 1;
        Speed = 3;
        Health = MainHealth= Level * 1000f;
        KillReward = Level * 15;
    }
    public ToughEnemy(int l)
    {
        Level = l;
        Speed = 3;
        Health = MainHealth = Level * 1000f;
        KillReward = Level * 15;
    }
    
}
