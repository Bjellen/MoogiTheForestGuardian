using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Growing_Flower : MonoBehaviour
{
    public bool isGrowing;

    public Vector3 maxScale;
    public Vector3 minScale;
    public float scaleGrowth = 1;

    private void Update()
    {
        if(isGrowing == true)
        {
            transform.localScale = Vector3.MoveTowards(transform.localScale, maxScale, scaleGrowth * Time.deltaTime);
        }
        else if (isGrowing == false)
        {
            transform.localScale = Vector3.MoveTowards(transform.localScale, minScale, scaleGrowth * Time.deltaTime);
        }
    }
}
