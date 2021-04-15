using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_MainMenu : MonoBehaviour
{
    public string firstLevel;
    public string currentLevel;

    public void NewGame()
    {
        //reset saves
        SceneManager.LoadScene(firstLevel);
    }  

    public void Resume()
    {
        //Load saves
        SceneManager.LoadScene(currentLevel);
    }

    public void QuitGame()
    {
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    } 
    
}
