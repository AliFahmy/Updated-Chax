using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy  {
    private float currentspeed;
    private float speed;
	private float health;
    private float mainHealth;
    private int killReward;
    private int level;
    private int score;

    public int Score
    {
        get
        {
            return score;
        }
        set
        {
            score = value;
        }
    }
    public Enemy()
    {
        level = 0;
        currentspeed= speed = 0;
        health = 0f;
        mainHealth = 0;
        killReward = 0;
    }
    public float Speed
    {
        get
        {
            return speed;
        }
        set
        {
            speed = value ;
        }
    }
    public float CurrentSpeed
    {
        get
        {
            return currentspeed;
        }
        set
        {
            currentspeed = value;
        }
    }
    public float Health
    {
        get
        {
            return health ;
        }
        set
        {
            health = value ;
        }
    }
    public int KillReward
    {
        get
        {
            return killReward;
        }
        set
        {
            killReward= value ;
        }
    }
    public int Level
    {
        get
        {
            return level;
        }
        set
        {
            level = value ;
        }
    }
	public float MainHealth
    {
        get
        {
            return mainHealth;
        }
        set
        {
            mainHealth = value;
        }
    }
}
