using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_LevelSelect : MonoBehaviour
{
    public string Level1;
    public string Level2;
    public string Level3;
    public string Level4;
    //Mia la inn denne, bare slett hvis det du vil:
    public string Level5;

    public GameObject MainMenuPanel;
    public GameObject LevelselectPanel;

    public void Level()
    {
        SceneManager.LoadScene(Level1);
    }
    public void Leve2()
    {
        SceneManager.LoadScene(Level2);
    }

    public void Leve3()
    {
        SceneManager.LoadScene(Level3);
    }

    public void Leve4()
    {
        SceneManager.LoadScene(Level4);
    }

    //Mia la inn denne, kan slettes hvis du vil
    public void Leve5()
    {
        SceneManager.LoadScene(Level5);
    }


    public void Back()
    {
        LevelselectPanel.SetActive(false);
        MainMenuPanel.SetActive(true);
    }
}
