using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Bullet
{
    protected float speed;
    protected float power;
    public Bullet()
    {
        speed = 0;
        power = 0;
    }
    public float Speed
    {
        get
        {
            return speed;
        }
        set
        {
            speed = value;
        }
    }
}
