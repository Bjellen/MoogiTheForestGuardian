using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPos : MonoBehaviour
{
    public CheckMaster cm;



    private void Awake()
    {
        cm = GameObject.FindGameObjectWithTag("CM").GetComponent<CheckMaster>();
        
    }
    void Start()
    {
       
        transform.position = cm.lastCheckPointPos[cm.checkPointIndex].transform.position;
    }
}
