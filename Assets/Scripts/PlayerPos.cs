using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPos : MonoBehaviour
{
    public CheckMaster cm;

    void Start()
    {
        cm = GameObject.FindGameObjectWithTag("CM").GetComponent<CheckMaster>();
        transform.position = cm.lastCheckPointPos;
    }
}
