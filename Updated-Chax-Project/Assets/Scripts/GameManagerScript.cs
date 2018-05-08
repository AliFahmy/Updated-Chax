using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
[Serializable]
class gameProperites
{
    public int startingCoins=0;
    public int startingLives = 0;
    public int StartingEnemyLevel = 0;
    public int WavesToWin = 0;

}
public class GameManagerScript : MonoBehaviour {
    public static GameClass Game;
    public static bool GameEnded;
    public GameObject GameOverUI;

    [SerializeField]
    gameProperites startingprop;
    
	// Use this for initialization
	void Start ()
    {
        //startingprop = new gameProperites();
        Game = new GameClass();
        Game.Coins = startingprop.startingCoins;
        Game._Lives = startingprop.startingLives;
        WaveSpawner.EnemyStartLevel = startingprop.StartingEnemyLevel;
        WaveSpawner.winwaves = startingprop.WavesToWin;
        GameEnded = false;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (GameEnded)
            return;
		if (Input.GetKeyDown ("e")) {
			EndGame ();
		}

        if (Game._Lives <= 0)
        {
            EndGame();
        }	
	}
    void EndGame()
    {
            GameEnded = true;
        GameOverUI.SetActive(true);
    }

    
}
