using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KinsFound : MonoBehaviour
{
    public static int kidFound;

    void Start()
    {
        kidFound = 0;
        GetComponent<BoxCollider2D>().enabled = false;
    }

    void Update()
    {
        if(kidFound == 2)
        {
            GetComponent<BoxCollider2D>().enabled = true;
        }
    }
}
