using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameClass  {
    private int coins;
    private int kills;
    private int score;
    private int wavesPassed;
    public static BaseBuilding MainBase;
    public int Coins
    {
        get
        {
            return coins;
        }
        set
        {
            coins = value;
        }
    }
    public int Kills
    {
        get
        {
            return kills;
        }
        set
        {
            kills = value;
        }
    }
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
    public int WavesPassed
    {
        get
        {
            return wavesPassed;
        }
        set
        {
            wavesPassed = value;
        }
    }
    public GameClass()
    {
        MainBase = new BaseBuilding(100);
        kills = 0;
        score = 0;
        coins = 200;
        wavesPassed = 0;

    }
}
