using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flute_Aura : MonoBehaviour
{
    public float auraRadius;
    [Tooltip("Lager en array med layermasks som den skal interacte med: 0 = enemy, 1 = plant")]
    public LayerMask[] interactables;

    private void Update()
    {
        Collider2D _enemyCollision = Physics2D.OverlapCircle(transform.position, auraRadius, interactables[0]);
        Collider2D _plantCollision = Physics2D.OverlapCircle(transform.position, auraRadius, interactables[1]);

        if (Input.GetKeyDown(KeyCode.E))
        {
            if(_enemyCollision != null)
            {
                _enemyCollision.GetComponent<MeshRenderer>().material.color = Color.green;
            }
            
            if(_plantCollision != null)
            {
                _plantCollision.GetComponent<Transform>().localScale = new Vector3(1,2,1);
            }
            
        }

       
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.magenta;
        Gizmos.DrawWireSphere(transform.position, auraRadius);
    }
}
