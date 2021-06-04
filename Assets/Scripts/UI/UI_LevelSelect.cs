using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_LevelSelect : MonoBehaviour
{
    public string houselevel;
    public string level1;
    public string level2;
    public string level3;
    //Mia la inn denne, bare slett hvis det du vil:
    public string level4;
    public string bossLevel;

    public GameObject MainMenuPanel;
    public GameObject LevelselectPanel;

    public void House()
    {
        SceneManager.LoadScene(houselevel);
    }
    public void Level1()
    {
        SceneManager.LoadScene(level1);
    }

    public void Level2()
    {
        SceneManager.LoadScene(level2);
    }

    public void Level3()
    {
        SceneManager.LoadScene(level3);
    }

    //Mia la inn denne, kan slettes hvis du vil
    public void Level4()
    {
        SceneManager.LoadScene(level4);
    }

    public void Boss()
    {
        SceneManager.LoadScene(bossLevel);
    }


    public void Back()
    {
        LevelselectPanel.SetActive(false);
        MainMenuPanel.SetActive(true);
    }
}
