using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class WinScript : MonoBehaviour {

    public Text wavenumbers;
	void OnEnable()
    {
        wavenumbers.text = (GameManagerScript.Game.WavesPassed).ToString();
        
        Time.timeScale = 0f;
    }
    public void Menu()
    {
        GameManagerScript.GameEnded = true;
        SceneManager.LoadScene("MainMenuScene");
    }
    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
}
