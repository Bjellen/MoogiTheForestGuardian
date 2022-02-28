
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_MainMenu1 : MonoBehaviour
{
    public string RWLevel1;
    public string currentLevel;

    public GameObject MainMenuPanel;
    public GameObject LevelselectPanel;

    public void NewGame()
    {
        //reset saves
        SceneManager.LoadScene(RWLevel1);
        print("Loading first level");
    }

    public void Resume()
    {
        //Load saves
        SceneManager.LoadScene(currentLevel);
        print("Loading Current Level");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void LeveSelect()
    {
        LevelselectPanel.SetActive(true);
        MainMenuPanel.SetActive(false);
    }
}
