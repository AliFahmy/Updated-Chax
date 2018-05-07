using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainMenuScript : MonoBehaviour {
	public string leveltoload;
	void Start()
	{
		leveltoload = "x";
	}

	public void Level1()
	{
		leveltoload = "FirstLevel";
		Debug.Log (leveltoload);
		SceneManager.LoadScene ("FirstLevel");
		//play ();
	}
	public void Level2 ()
	{
		leveltoload = "SecondLevel";
		play ();
	}
	public void Level3()
	{
		leveltoload = "ThirdLevel";
		play ();
	}
	public void play()
	{
		SceneManager.LoadScene (leveltoload);
	}
    
}
