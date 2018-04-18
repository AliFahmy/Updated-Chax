using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour {
    public static GameClass Game;
    private bool GameEnded;
	// Use this for initialization
	void Start () {
        Game = new GameClass();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (GameEnded)
            return;
        if (Game._Lives <= 0)
        {
            EndGame();
        }	
	}
    void EndGame()
    {
            GameEnded = true;
        Debug.Log("Game Ended");
    }
}
