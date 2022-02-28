using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_LevelSelect : MonoBehaviour
{
    //public string houselevel;
    public string RWLevel1;
    public string RWLevel3;
    public string RWLevel2;
    //Mia la inn denne, bare slett hvis det du vil:
    public string RWLevel4;
    //public string bossLevel;

    public GameObject MainMenuPanel;
    public GameObject LevelselectPanel;

    //public void House()
    //{
      //  SceneManager.LoadScene(houselevel);
    //}
    public void Level1()
    {
        SceneManager.LoadScene(RWLevel1);
    }

    public void Level3()
    {
        SceneManager.LoadScene(RWLevel3);
    }

    public void Level2()
    {
        SceneManager.LoadScene(RWLevel2);
    }

    //Mia la inn denne, kan slettes hvis du vil
    public void Level4()
    {
        SceneManager.LoadScene(RWLevel4);
    }

    //public void Boss()
    //{
       // SceneManager.LoadScene(bossLevel);
    //}


    public void Back()
    {
        LevelselectPanel.SetActive(false);
        MainMenuPanel.SetActive(true);
    }
}
