using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckMaster : MonoBehaviour
{
    private static CheckMaster instance;
    public GameObject[] lastCheckPointPos;
    public int checkPointIndex;

    private void Awake()
    {
        
        if (instance == null)
        {
            lastCheckPointPos = GameObject.FindGameObjectsWithTag("SpawnPoint");
            checkPointIndex = 0;
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
