using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class UI_InputCommunicator : MonoBehaviour
{
    public UI_PauseMenu pauseMenu;

    private void Awake()
    {
        pauseMenu = GameObject.FindGameObjectWithTag("GUIMaster").GetComponentInChildren<UI_PauseMenu>();
    }

    void OnPause()
    {
        //print("I DID IT :DD ");
        if (pauseMenu.gameIsPaused == false)
        {
            pauseMenu.gameIsPaused = true;
        }
        else if (pauseMenu.gameIsPaused == true)
        {
            pauseMenu.gameIsPaused = false;
        }

    }
}
