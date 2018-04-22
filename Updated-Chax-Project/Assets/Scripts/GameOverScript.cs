using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameOverScript : MonoBehaviour
{
    public GameObject MainMenuUI;
    public Text RoundsText;
 
    void OnEnable()
    {
        RoundsText.text = (WaveSpawner.wavenumber-1).ToString();
    }
    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Menu()
    {
        GameManagerScript.GameEnded = true;
        MainMenuUI.SetActive(true);
    }
	
}
