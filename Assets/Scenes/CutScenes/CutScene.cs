using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutScene : MonoBehaviour
{
    public int timer;
    
    private void Start()
    {
        StartCoroutine(playVideo());
    }
    IEnumerator playVideo()
    {
        yield return new WaitForSeconds(timer);
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("CutScene6"))
        {
            SceneManager.LoadScene("MainMenu");
            
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }
    public void skipButton()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("CutScene7"))
        {
            SceneManager.LoadScene("MainMenu");

        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
