using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Buildings  {

    private int Attack;
    private float Range;
    private int AttackSpeed;
    public int Reloadtime;
    public int attackSpeed
    {
        get
        {
            return AttackSpeed;
        }
        set {
            AttackSpeed = value;
        }
    }
    public int attack
    {
        get
        {
            return Attack;
        }
        set
        {
            Attack = value;
        }
    }
    public float range
    {
        get
        {
            return Range;
        }
        set
        {
            Range = value;
        }
    }
    public Buildings()
    {
        Attack = 0;
        Range = 0.0f;
        Reloadtime = 0;
    }
}
