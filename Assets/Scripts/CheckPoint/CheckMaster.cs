using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckMaster : MonoBehaviour
{
    [SerializeField]
    private static CheckMaster instance;
    public GameObject[] lastCheckPointPos;
    public int checkPointIndex;

    private void Awake()
    {
        checkPointIndex = 0;
    }
}
