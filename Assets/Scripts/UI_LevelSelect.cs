using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_LevelSelect : MonoBehaviour
{
    public GameObject PauseMenu;
    public bool GameIsPaused;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }

    }

    void PauseGame()
    {
        PauseMenu.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    void ResumeGame()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    public void Bounce()
    {
        SceneManager.LoadScene("BouncePlatforms_TestRoom");
    }

    public void Enemies()
    {
        SceneManager.LoadScene("Enemies_TestRoom");
    }

    public void GrowingPlant()
    {
        SceneManager.LoadScene("GrowingPlant_TestRoom");
    }

    public void Ladder()
    {
        SceneManager.LoadScene("Ladder_TestRoom");
    }

    public void TestLevel()
    {
        SceneManager.LoadScene("Testscene");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
