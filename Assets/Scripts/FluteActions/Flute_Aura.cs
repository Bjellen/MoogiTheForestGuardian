using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flute_Aura : MonoBehaviour
{
    public float auraRadius;
    [Tooltip("Lager en array med layermasks som den skal interacte med: 0 = enemy, 1 = plant")]
    public LayerMask[] interactables;

    public Growing_Flower growingFlower;


    private void Update()
    {
        Collider2D _enemyCollision = Physics2D.OverlapCircle(transform.position, auraRadius, interactables[0]);
        Collider2D _plantCollision = Physics2D.OverlapCircle(transform.position, auraRadius, interactables[1]);

        if (Input.GetKey(KeyCode.E))
        {
            if (_enemyCollision != null)
            {
                _enemyCollision.tag = "Friend";
            }

            if (_plantCollision != null)
            {
                growingFlower.isGrowing = true;
            }
        }
       
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
