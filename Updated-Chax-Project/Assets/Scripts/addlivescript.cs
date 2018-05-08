using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class addlivescript : MonoBehaviour {

    public Text KillsText;
    public Text ScoreText;
    private void Update()
    {
        KillsText.text = "Kills : " + GameManagerScript.Game.Kills.ToString();
        ScoreText.text = "Score : " + GameManagerScript.Game.Score.ToString();
    }
    public void addlives()
    {
        
        if (GameManagerScript.Game.Coins>= 100)
        {
            GameManagerScript.Game.Coins -= 100;
            GameManagerScript.Game._Lives++;
        }
    }
}
