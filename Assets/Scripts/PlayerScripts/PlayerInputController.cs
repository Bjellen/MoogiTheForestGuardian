using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : MonoBehaviour
{
    [Header ("Movement Variables")]
    private Vector2 moveVector;

    [Header ("Player")]
    private Rigidbody2D rb2D;
    private bool facingRight;

    private Collider2D myCollider;
    public Collider2D interactCollider;

    public float moveSpeed;
    public float jumpForce;
    public float amountOfJump;
    public float maxAmountOfJump;

    [Header("GroundChecks")]
    public LayerMask whatIsGround;

    [Header("LadderMovement")]
    public bool isClimbing;

    [Header("HoneyMovement")]
    public bool inHoney;


    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        myCollider = GetComponent<Collider2D>();
    }

    void OnMove(InputValue value)
    {
        moveVector = value.Get<Vector2>();
        //Debug.Log("I'm on the move now" + "x =" + moveVector.x + "y =" + moveVector.y);
    }

    void OnJump()
    {
        Jump();
    }

    private void Update()
    {
        Movement();

        if(amountOfJump < maxAmountOfJump)
        { amountOfJump = maxAmountOfJump; }

        if (moveVector.y < -0.5 && interactCollider != null)
        { Physics2D.IgnoreCollision(interactCollider, myCollider, true); }

        if (interactCollider && transform.position.y < interactCollider.transform.position.y)
        {
            Physics2D.IgnoreCollision(interactCollider, myCollider, false);
            interactCollider = null;
        }
    }

    private void FixedUpdate()
    {
        if (isClimbing == false && inHoney == false)
        { Movement(); }

        if (isClimbing == true)
        { Climb(); }

        if (inHoney == true)
        { HoneyMovement(); }
    }

    #region Movement 
    void Movement()
    {
        rb2D.velocity = new Vector2(moveVector.x * moveSpeed, rb2D.velocity.y);
    }

    void Jump()
    {
        if (IsGrounded() && amountOfJump > 0 )
        {
            rb2D.velocity = new Vector2(rb2D.velocity.x, jumpForce);
        }
    }

    void HoneyMovement()
    {
        rb2D.velocity = new Vector2(moveVector.x * (moveSpeed / 2), rb2D.velocity.y / 2);
    }

    void Climb()
    {
        rb2D.velocity = new Vector2(0, moveVector.y * moveSpeed);
    }
    #endregion

    #region Extra checks
    bool IsGrounded()
    {
        var _position = transform.position;
        var _direction = -Vector2.up;
        float _distance = 1.5f;

        var hit = Physics2D.Raycast(_position, _direction, _distance, whatIsGround);
        amountOfJump += 1;

        Debug.DrawRay(_position, _direction, Color.green);

        return hit.collider != null;
    }
    #endregion

    #region Collision / Trigger Checks
    private void OnCollisionEnter2D(Collision2D collision)
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

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "LadderBottom" && moveVector.y > 0.5)
        {
            isClimbing = true;
        }
        else if(collision.gameObject.tag == "LadderBottom" && moveVector.y < -0.5)
        {
            isClimbing = false;
        }

        if (collision.gameObject.tag == "LadderTop" && moveVector.y < -0.5)
        {
            isClimbing = true;
        }
        else if (collision.gameObject.tag == "LadderTop" && moveVector.y > 0.5)
        {
            isClimbing = false;
        }

        if (collision.gameObject.tag == "Honey")
        {
            inHoney = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Honey")
        {
            inHoney = false;
        }
    }
    #endregion
}