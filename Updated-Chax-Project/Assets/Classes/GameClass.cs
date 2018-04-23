using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameClass  {
    private int coins;
    private int kills;
    private int score;
    private int enemiesalive;
    private int wavesPassed;
    private static int Lives;
    private int startlives;
    public StandardTurret standardTurretTemp;
    public MissleTurret missleLuncherTemp;
    public LaserTurret LaserTurretTemp;
    public static BaseBuilding MainBase;
    public int EnemiesAlive
    {
        get
        {
            return enemiesalive;
        }
        set
        {
            enemiesalive = value;
        }
    }
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
    public int _Lives
    {
        get
        {
            return Lives;
        }
        set
        {
            Lives = value;
        }
    }
    public GameClass()
    {
        MainBase = new BaseBuilding(100);
        standardTurretTemp = new StandardTurret();
        missleLuncherTemp = new MissleTurret();
        LaserTurretTemp = new LaserTurret();
        kills = 0;
        score = 0;
        coins = 500;
        wavesPassed = 0;
        startlives = 50;
        Lives = startlives;
    }
      
}
