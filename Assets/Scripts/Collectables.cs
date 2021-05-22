using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("HEIHEI");
        var player = other.GetComponent<PlayerInputController>();
        if (player != null)
        {
            player.Collectables++;
            FindObjectOfType<CollectableUI>().score++;
            Destroy(gameObject);
        }
    }
}
