using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPos : MonoBehaviour
{
    public CheckMaster cm;

    public Vector2 playerPos;

    private void Awake()
    {
        cm = GameObject.FindGameObjectWithTag("CM").GetComponent<CheckMaster>();
        playerPos = cm.lastCheckPointPos;
    }
    void Start()
    {
        transform.position = playerPos;
    }
}
