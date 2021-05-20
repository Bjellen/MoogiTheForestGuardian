using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Growing_Flower : MonoBehaviour
{
    public Animator anim;
    public bool isGrowing;

    public Vector3 maxScale;
    public Vector3 minScale;
    public float scaleGrowth = 1;

    private void Start()
    {
        transform.localPosition = minScale;
       
    }
    private void Update()
    {
        
        if(isGrowing == true)
        {
            transform.localPosition = Vector3.MoveTowards(transform.localPosition, maxScale, scaleGrowth * Time.deltaTime);
            anim.SetBool("IsGrowing", true);
        }
        else if (isGrowing == false)
        {
            transform.localPosition = Vector3.MoveTowards(transform.localPosition, minScale, scaleGrowth * Time.deltaTime);
            if(transform.localPosition == minScale)
            {
                anim.SetBool("IsGrowing", false);
            }
        }
    }
}
