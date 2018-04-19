using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandardBullet : Bullet
{
    public StandardBullet()
    {
        ExplosionRadius = 0f;
        Speed = 70f;
        Power = 50;
    }
    public StandardBullet(int p)
    {
        ExplosionRadius = 0f;
        Speed = 70f;
        Power = p;
    }
}
