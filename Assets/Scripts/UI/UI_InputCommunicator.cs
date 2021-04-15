using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class UI_InputCommunicator : MonoBehaviour
{
    public UI_PauseMenu pauseMenu;


    void OnPause()
    {
        print("I DID IT :DD ");
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
