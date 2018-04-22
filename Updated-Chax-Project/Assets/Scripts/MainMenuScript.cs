using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainMenuScript : MonoBehaviour {
    public  GameObject MainMenuUI;
    public static bool gamestarted;
    void Awake()
    {
        gamestarted = false;
    }
    public void Update()
    {
        if (gamestarted == true)
        {
            MainMenuUI.SetActive(false);
        }
    }
    public void StartGame()
    {
        gamestarted = true;
        MainMenuUI.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void EndGame()
    {
        Application.Quit();
    }
    
}
