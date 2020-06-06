using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPause = false;

    public GameObject pauseMenuUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPause)
            {
                Resume();
            }

            else
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        GameObject.Find("Player").layer = LayerMask.NameToLayer("Default");
        Time.timeScale = 1f;
        GameIsPause = false;
    }
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        GameObject.Find("Player").layer = LayerMask.NameToLayer("Test Layer");
        Time.timeScale = 0f;
        GameIsPause = true;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
        //Destroy(GameObject.Find("AudioManager"));
        //Destroy(GameObject.Find("Player"));
    }

    public void QuitGame()
    {
        Debug.Log("Quitng Game....");
        Application.Quit();
    }
}
