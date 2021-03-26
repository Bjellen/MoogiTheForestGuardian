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

    void OnFlutePlay()
    {
        if (enemyCollision != null)
        {
            enemyCollision.tag = "Friend";
        }

        if (plantCollision != null)
        {
            growingFlower = plantCollision.GetComponent<Growing_Flower>();
            growingFlower.isGrowing = true;
        }
    }

    private void Update()
    {
        enemyCollision = Physics2D.OverlapCircle(transform.position, auraRadius, interactibles[0]);
        plantCollision = Physics2D.OverlapCircle(transform.position, auraRadius, interactibles[1]);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "GrowingPlant")
        {
            growingFlower.isGrowing = false;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.magenta;
        Gizmos.DrawWireSphere(transform.position, auraRadius);
    }

}
