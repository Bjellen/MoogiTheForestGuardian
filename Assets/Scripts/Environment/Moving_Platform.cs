using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_Platform : MonoBehaviour
{
    public Transform[] Points; //0 is A (to the left), 1 is B (to the right)
    public GameObject player;

    public bool[] leftRight;//Left is 0, right is 1

    public float speed;
    public int delayTime;

    public Transform playerCollision;

    public bool onCloud;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        onCloud = false;

        leftRight[0] = false;
        leftRight[1] = true;
    }

    private void Update()
    {
        if (leftRight[0])
        {
            transform.position = Vector2.MoveTowards(transform.position, Points[0].position, speed * Time.deltaTime);
        }
        else if (leftRight[1])
        {
            transform.position = Vector2.MoveTowards(transform.position, Points[1].position, speed * Time.deltaTime);
        }

        if(Vector2.Distance(Points[0].position, transform.position) < 0.001)
        {
            StartCoroutine(Wait());
            leftRight[0] = false;
            leftRight[1] = true;
        }
        if (Vector2.Distance(Points[1].position, transform.position) < 0.001)
        {
            StartCoroutine(Wait());
            leftRight[0] = true;
            leftRight[1] = false;
        }

        if(onCloud == true)
        {
            OnCloud();
        }
        else
        {
            OffCloud();
        }

    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(delayTime);
    }

    void OnCloud()
    {
        playerCollision.transform.parent = transform;
    }

    void OffCloud()
    {
        playerCollision.transform.parent = player.transform;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        playerCollision = collision.gameObject.GetComponent<Transform>();

        if (playerCollision != null)
        {
            onCloud = true;
        }
        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        onCloud = false;
    }

}
