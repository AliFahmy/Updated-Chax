using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Bullet
{
    private float speed;
    private float power;
    private float explosionRadius;
    public Bullet()
    {
        speed = 0f;
        power = 0f;
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
    public float Power
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
