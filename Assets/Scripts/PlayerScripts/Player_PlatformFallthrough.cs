using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_PlatformFallthrough : MonoBehaviour
{
    public Collider2D interactCollider;
    private Collider2D myCollider;

    public float y;

    private void Start()
    {
        myCollider = GetComponent<Collider2D>();
    }

    private void Update()
    {
        y = Input.GetAxisRaw("Vertical");

        if( y < 0 && interactCollider != null)
        {
            Physics2D.IgnoreCollision(interactCollider, myCollider, true);
        }

        if(transform.position.y < interactCollider.transform.position.y)
        {
            Physics2D.IgnoreCollision(interactCollider, myCollider, false);
            interactCollider = null;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            interactCollider = collision.gameObject.GetComponent<Collider2D>();
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            interactCollider = collision.gameObject.GetComponent<Collider2D>();
        }
    }

}
