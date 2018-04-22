using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBullet : Bullet
{
    public LaserBullet()
    {
        Speed = 100f;
        Power = 200;
    }
	public LaserBullet(int p)
	{
		Speed = 100f;
		Power = p;
	}
	
}
