using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour {
    public GameObject UI;
    public GameObject addlivesui;

	void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P))
        {
            Toggle();
        }
    }
    public void Toggle()
    {

        UI.SetActive(!UI.activeSelf);
        if (UI.activeSelf)
        {
            addlivesui.SetActive(false);
            Time.timeScale = 0f;
            
        }
        else
        {
            addlivesui.SetActive(true);
            Time.timeScale = 1f;
        }
    }
    public void Retry()
    {
        Toggle();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);       
    }
    public void Menu()
    {
        Toggle();
        SceneManager.LoadScene("MainMenuScene");
    }
    public void Exit()
    {
        Application.Quit();
    }
}
