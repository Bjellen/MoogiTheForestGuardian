using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPos : MonoBehaviour
{
    private CheckMaster cm;

    void Start()
    {
        cm = GameObject.FindGameObjectWithTag("CM").GetComponent<CheckMaster>();
        transform.position = cm.lastCheckPointPos;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
