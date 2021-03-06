using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player_FluteAura : MonoBehaviour
{
    public float auraRadius;

    public LayerMask[] interactibles;

    public Growing_Flower growingFlower;

    private Collider2D enemyCollision;
    private Collider2D plantCollision;
    public Animator animator;

    private MobileInput mobileInput;
    private bool isPlaying;

    public AudioSource source;


    private void Awake()
    {
        mobileInput = new MobileInput();
        isPlaying = false;
    }

    private void OnEnable()
    {
        mobileInput.Enable(); 
    }

    private void OnDisable()
    {
        mobileInput.Disable();
    }

    private void Start()
    {
        mobileInput.Mobile.FlutePlay.started += _ => isPlaying = true;
        mobileInput.Mobile.FlutePlay.canceled += _ => isPlaying = false;
    }
    void OnFlutePlay()
    {
        if (enemyCollision != null)
        {
            enemyCollision.tag = "Friend";
        }

        if (plantCollision != null)
        {
            growingFlower.isGrowing = true;
        }    

    }

    private void Update()
    {
        enemyCollision = Physics2D.OverlapCircle(transform.position, auraRadius, interactibles[0]);
        plantCollision = Physics2D.OverlapCircle(transform.position, auraRadius, interactibles[1]);

        if( plantCollision != null)
        {
            growingFlower = plantCollision.GetComponentInParent<Growing_Flower>();
        }
        else if(plantCollision)
        {
            growingFlower.isGrowing = false;
            growingFlower = null;
        }
        animator.SetBool("IsPlaying", isPlaying);
        if (isPlaying && !source.isPlaying)
        {
            source.Play();
        }

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "GrowingPlant")
        {
            growingFlower.isGrowing = false;
        }
    }

    //private void OnDrawGizmos()
    //{
    //    Gizmos.color = Color.magenta;
    //    Gizmos.DrawWireSphere(transform.position, auraRadius);
    //}

}
