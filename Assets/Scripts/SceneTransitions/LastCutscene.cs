using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LastCutscene : MonoBehaviour
{
    public int timer;

    private void Start()
    {
        StartCoroutine(playVideo());
    }

    IEnumerator playVideo()
    {
        yield return new WaitForSeconds(timer);
        SceneManager.LoadScene("MainMenu");
    }
}
