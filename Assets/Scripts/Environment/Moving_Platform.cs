using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Moving_Platform : MonoBehaviour
{
    public Transform[] Points; //0 is A (to the left), 1 is B (to the right)
    public GameObject player;
    public Transform playerCharacter;

    public bool[] leftRight;//Left is 0, right is 1

    public float speed;
    public int delayTime;

    public Transform playerCollision;
    public Transform CloudTransform;

    public bool onCloud;

    public Text DebugText;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerCharacter = player.GetComponentInChildren<Transform>();
        playerCollision = playerCharacter.GetComponentInChildren<Transform>();
        CloudTransform = GetComponent<Transform>();
    }

    private void Start()
    {
        leftRight[0] = false;
        leftRight[1] = true;

        onCloud = false;

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

        DebugText.text = "On cloud is " + onCloud;

        if(playerCollision && onCloud == true)
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
        playerCollision.transform.parent = CloudTransform;

    }

    void OffCloud()
    {
        
        playerCollision.transform.parent = playerCharacter.transform;
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            
            onCloud = true;
            
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            playerCollision.transform.parent = null;
            onCloud = false;

        }
        
    }

}
