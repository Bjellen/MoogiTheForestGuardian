using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSpawnpointMover : MonoBehaviour
{
    public GameObject bossSpawn;
    public GameObject spawnPointLocation;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            bossSpawn.transform.position = spawnPointLocation.transform.position;
        }
    }
}
