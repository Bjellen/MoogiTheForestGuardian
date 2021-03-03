using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    [Header("Movement Variables")]
    public float moveSpeed;
    public float jumpForce;

    [Header("the bod")]
    private Rigidbody2D rb2D;
    private bool facingRight;

    [Header("GroundCheck")]
    public LayerMask whatIsGround;

    [Header("Input Checks")]
    public float x;
    public float y;

    [Header("LadderMovement")]
    public bool isClimbing;

    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        isClimbing = false;
    }

    private void Update()
    {
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        { Jump(); }

    }

    private void FixedUpdate()
    {
        if (isClimbing == false)
        { Movement(); }

        if (isClimbing == true)
        { Climb(); }

        if(facingRight == false && x < 0) { Flip(); }
        else if(facingRight == true && x > 0 ) { Flip(); }
    }

    void Movement()
    {
        rb2D.velocity = new Vector2(x * moveSpeed, rb2D.velocity.y);
    }

    void Jump()
    {
        rb2D.velocity = new Vector2(rb2D.velocity.x, jumpForce);
    }

    bool IsGrounded()
    {
        var _position = transform.position;
        var _direction = -Vector2.up;
        float _distance = 1.5f;

        var hit = Physics2D.Raycast(_position, _direction, _distance, whatIsGround);
        Debug.DrawRay(_position, _direction, Color.green);

        return hit.collider != null;
    }

    void Flip()
    {
        facingRight = !facingRight;
        transform.Rotate(0, 180, 0);
    }

    void Climb()
    {
        rb2D.velocity = new Vector2(0, y * moveSpeed);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "LadderBottom" && y > 0)
        {
            isClimbing = true;
        }
        else if (collision.gameObject.tag == "LadderBottom" && y < 0)
        {
            isClimbing = false;
        }

        if (collision.gameObject.tag == "LadderTop" && y < 0)
        {
            isClimbing = true;
        }
        else if (collision.gameObject.tag == "LadderTop" && y > 0)
        {
            isClimbing = false;
        }

    }

}

