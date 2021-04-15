using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class UI_PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public bool gameIsPaused;
    public string mainMenuName;
    
    private void Awake()
    {
        pauseMenu.SetActive(false);
    }


    private void Update()
    {
        if(gameIsPaused == true)
        {
            Time.timeScale = 0;
            pauseMenu.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            pauseMenu.SetActive(false);
        }
    }

    public void PauseGame()
    {
       if(gameIsPaused == false)
        {
            gameIsPaused = true;
        }
       else if(gameIsPaused == true)
        {
            gameIsPaused = false;
        }  
    }


    public void MainMenu()
    {
        print("Loading Scene...");
        SceneManager.LoadScene(mainMenuName);
    }

    public void Resume()
    {
        print("Resuming game...");
        gameIsPaused = false;
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
    }

}
