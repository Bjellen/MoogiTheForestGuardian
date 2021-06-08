using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        var player = other.GetComponent<PlayerInputController>();
        if (player != null)
        {
            KinsFound.kidFound++;
            Destroy(gameObject);
        }
    }
}
