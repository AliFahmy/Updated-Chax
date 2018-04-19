using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissleBullet : Bullet
{
    
    public MissleBullet()
    {
        Speed = 30f;
        Power = 100;
        ExplosionRadius = 10f;
    }
    public MissleBullet(int p)
    {
        Speed = 30f;
        Power = p;
        ExplosionRadius = 10f;
    }

}
