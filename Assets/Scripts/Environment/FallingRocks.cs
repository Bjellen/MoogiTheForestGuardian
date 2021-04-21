using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingRocks : MonoBehaviour
{
    //gi den en static body type
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        { DropRock(); }
    }

    public void DropRock()
    {
        //Change body type from Static to dynamic 
        rb.bodyType = RigidbodyType2D.Dynamic;
    }
}
