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
    public Transform flower;
    private void Start()
    {
        flower.localPosition = minScale;

    }
    private void Update()
    {

        if (isGrowing == true)
        {
            flower.localPosition = Vector3.MoveTowards(flower.localPosition, maxScale, scaleGrowth * Time.deltaTime);
            anim.SetBool("IsGrowing", true);
            flower.GetComponent<BoxCollider2D>().enabled = true;
        }
        else if (isGrowing == false)
        {
            flower.localPosition = Vector3.MoveTowards(flower.localPosition, minScale, scaleGrowth * Time.deltaTime);
            if (flower.localPosition == minScale)
            {
                anim.SetBool("IsGrowing", false);
                flower.GetComponent<BoxCollider2D>().enabled = false;
            }
        }
    }
}
