using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addlivescript : MonoBehaviour {

	public void addlives()
    {
        if (GameManagerScript.Game.Coins>= 100)
        {
            GameManagerScript.Game.Coins -= 100;
            GameManagerScript.Game._Lives++;
        }
    }
}
