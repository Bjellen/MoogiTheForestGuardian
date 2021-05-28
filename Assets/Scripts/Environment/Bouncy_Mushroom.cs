using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncy_Mushroom : MonoBehaviour
{
    public float jumpForce;
    public Animator animator;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Rigidbody2D rb2D = collision.gameObject.GetComponent<Rigidbody2D>();
            rb2D.velocity = new Vector2(rb2D.velocity.x, jumpForce);
            animator.Play("Scared");
            GetComponentInChildren<PlayAudioClip>().PlayAudio();
        }
    }
}
