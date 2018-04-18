using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopCanvasScript : MonoBehaviour {
    public Text Lives;

	// Update is called once per frame
	void Update () {
        Lives.text ="Lives : "+ GameManagerScript.Game._Lives.ToString();
	}
}
