using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Bullet
{
    private float speed;
    private int power;
    private float explosionRadius;
    public Bullet()
    {
        speed = 0f;
        power = 0;
        explosionRadius = 0f;
        
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
    public int Power
    {
        get
        {
            return power;
        }
        set
        {
            power = value;
        }
    }
    public float ExplosionRadius
    {
        get
        {
            return explosionRadius;
        }
        set
        {
            explosionRadius = value;
        }
    }
}
