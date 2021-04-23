using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
    public string MainMenu;
    public void mainMenu()
    {
        SceneManager.LoadScene(0);
    }

}
