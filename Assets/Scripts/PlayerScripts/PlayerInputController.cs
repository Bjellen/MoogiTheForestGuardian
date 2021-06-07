using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : MonoBehaviour
{
    [Header("Movement Variables")]
    private Vector2 moveVector;

    [Header("Player")]
    private Rigidbody2D rb2D;
    private bool facingRight;

    public SpriteRenderer sprite;

    private Collider2D myCollider;
    public Collider2D interactCollider;

    public float moveSpeed;
    public float jumpForce;
    public float amountOfJump;
    public float maxAmountOfJump;

    public int Collectables;

    public Animator animatior;

    public ParticleSystem dust;

    [Header("Audio")]
    public AudioClip[] movementSound;
    public AudioClip honeySound;
    public AudioClip jumpingSound;
    public float pitchMin, pitchMax;
    public int movementIndex;
    public bool isMoving;
    bool _jumpSound;
    AudioSource audioScr;

    [Header("GroundChecks")]
    public LayerMask whatIsGround;
    public bool isGrounded;

    [Header("LadderMovement")]
    public bool isClimbing;
    public float rayDistance;
    public LayerMask whatIsLadder;

    public bool onPlatform;

    [Header("HoneyMovement")]
    public bool inHoney;

    private PlayerHealth health;

    private void Awake()
    {
        audioScr = GetComponent<AudioSource>();
    }

    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        myCollider = GetComponent<Collider2D>();
        sprite = GetComponent<SpriteRenderer>();

        health = GetComponent<PlayerHealth>();

        audioScr.clip = movementSound[movementIndex];

        onPlatform = false;
    }

    void OnMove(InputValue value)
    {
        moveVector = value.Get<Vector2>();
        //Debug.Log("I'm on the move now" + "x =" + moveVector.x + "y =" + moveVector.y);
    }

    void OnJump()
    {
        if (isGrounded)
        Jump();
    }

    private void Update()
    {
        Movement();

        if (IsGrounded())
        {
            if (amountOfJump <= 0)
            { amountOfJump += 1; }

            Debug.Log("I'm grounded");
            isGrounded = true;
        }
        else
        { isGrounded = false; }

        if (amountOfJump > maxAmountOfJump)
        { amountOfJump = maxAmountOfJump; }

        if (moveVector.y < -0.5 && interactCollider != null)
        {   
            Physics2D.IgnoreCollision(interactCollider, myCollider, true);
        }

        if (interactCollider && transform.position.y < interactCollider.transform.position.y && onPlatform == false)
        {
            Physics2D.IgnoreCollision(interactCollider, myCollider, false);
            interactCollider = null;
        }

        if (moveVector.x < -0.5)
        { Flip(); }
        else if (moveVector.x > 0.5)
        { FlipBack(); }

        animatior.SetBool("IsJumping", !isGrounded);
    }

    private void FixedUpdate()
    {
        if(health.knockBack == false)
        { 
            if (isClimbing == false && inHoney == false)
            { Movement();}

            if (inHoney == true)
            { HoneyMovement(); }

            
        }

        if (isClimbing == true)
        {
            Climb();
            rb2D.gravityScale = 0;
        }
        else
        {
            rb2D.gravityScale = 1;
        }

        RaycastHit2D _hitInfoUp = Physics2D.Raycast(transform.position, Vector2.up, rayDistance, whatIsLadder);
        RaycastHit2D _hitInfoDown = Physics2D.Raycast(transform.position, -Vector2.up, rayDistance, whatIsLadder);

        if (_hitInfoUp.collider != null)
        {
            if (moveVector.y > 0)
            {
                isClimbing = true;
            }
        }
        else
        {
            isClimbing = false;
        }

        if (_hitInfoDown.collider != null)
        {
            if (moveVector.y < 0)
            {
                isClimbing = true;
            }
        }
        else
        {
            isClimbing = false;
        }
    }

    #region Movement functions (eks. move, Jump)
    void Movement()
    {
        rb2D.velocity = new Vector2(moveVector.x * moveSpeed, rb2D.velocity.y);
        animatior.SetFloat("Speed", moveVector.x);
        PlayMovementAudio();
        isMoving = true;
    }

    void Jump()
    {
        CreateDust();
        if (amountOfJump > 0)
        {
            rb2D.velocity = new Vector2(rb2D.velocity.x, jumpForce);
            amountOfJump = 0;
            _jumpSound = true;
            PlayJumpAudio();
        }

        else if (amountOfJump <= 0)
        {
            rb2D.velocity = new Vector2(rb2D.velocity.x, rb2D.velocity.y);
            audioScr.volume = 1;
        }
    }


    void HoneyMovement()
    {
        rb2D.velocity = new Vector2(moveVector.x * (moveSpeed / 2), rb2D.velocity.y / 2);      
    }

    void Climb()
    {
        rb2D.velocity = new Vector2(rb2D.velocity.x, moveVector.y * moveSpeed);

    }
    #endregion

    #region Movement Audio
    void PlayMovementAudio()
    {
        
        if (audioScr.isPlaying && moveVector.x == 0 && isGrounded && _jumpSound == false )
        {
            audioScr.Stop();
        }
        else if(!audioScr.isPlaying && moveVector.x != 0 && isGrounded)
        {
            //audioScr.pitch = Random.Range(pitchMin, pitchMax);
            if(inHoney == true)
            {
                audioScr.clip = honeySound;
            }
            else
            {
                audioScr.clip = movementSound[movementIndex];
            }
            audioScr.Play();
        }
               
    }
    void PlayJumpAudio()
    {
        audioScr.volume = 0.5f;
        audioScr.pitch = Random.Range(pitchMin, pitchMax);
        audioScr.PlayOneShot(jumpingSound);
    }

    #endregion

    #region Extra checks
    bool IsGrounded()
    {
        var _position = transform.position;
        var _direction = -Vector2.up;
        float _distance = 2.2f;

        var hit = Physics2D.Raycast(_position, _direction, _distance, whatIsGround);
        Debug.DrawRay(_position, _direction * _distance, Color.green);


        return hit.collider != null;
    }
    #endregion

    #region Collision / Trigger Checks
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            interactCollider = collision.gameObject.GetComponent<Collider2D>();
            onPlatform = true;
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

        if(collision.gameObject.tag == "Platform")
        {
            onPlatform = false;
            
        }
    }
    #endregion

    #region Flip functions
    void Flip()
    {
        sprite.flipX = true;
    }

    void FlipBack()
    {
        sprite.flipX = false;
    }
    #endregion

    void CreateDust()
    {
        dust.Play();
    }
}