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
        Time.timeScale = 1f;
        GameManagerScript.GameEnded = true;
        SceneManager.LoadScene("MainMenuScene");
    }
    public void Retry()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
}
