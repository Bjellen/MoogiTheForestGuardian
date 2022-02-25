using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Enemy_Walk : MonoBehaviour
{

    [Header("Movement")]
    public float moveSpeed;

    public bool[] leftRight;

    public Transform[] points;
    public int stopTime;

    public Collider2D enemyCollider;

    public Animator animator;

    private void Start()
    {
        GetComponentInChildren<PlayAudioClip>().PlayAudio();
    }
    private void Update()
    {
        if (leftRight[0])
        {
            transform.position = Vector2.MoveTowards(transform.position, points[0].position, moveSpeed * Time.deltaTime);
            print("i'm moving");
        }
        else if (leftRight[1])
        {
            transform.position = Vector2.MoveTowards(transform.position, points[1].position, moveSpeed * Time.deltaTime);
            print("I'm moving back");
        }

        if(Vector2.Distance(points[0].position,transform.position) < 0.001)
        {
            StartCoroutine(Wait());
            FlipBack();
            leftRight[0] = false;
            leftRight[1] = true;
        }
        if (Vector2.Distance(points[1].position, transform.position) < 0.001)
        {
            StartCoroutine(Wait());
            Flip();
            leftRight[0] = true;
            leftRight[1] = false;
        }

        if (gameObject.tag == "Friend")
        {
            GetComponentInChildren<PlayAudioClip>().AudioStop();
            enemyCollider.isTrigger = true;
            //GetComponent<MeshRenderer>().material.color = Color.green;
            points[0].transform.position = enemyCollider.transform.position;
            points[1].transform.position = enemyCollider.transform.position;
            animator.applyRootMotion = false;
            animator.SetTrigger("Sleep");
            this.enabled = false;

            //legg inn sove animasjon her :D
        }

    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(stopTime);
    }

    #region Flip functions
    void Flip()
    {
        transform.rotation = Quaternion.Euler(0, 180, 0);
    }
    
    void FlipBack()
    {
        transform.rotation = Quaternion.Euler(0, 0, 0);
    }
    #endregion
}
