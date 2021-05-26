using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_Chase : MonoBehaviour
{
    [Header("Movement variables")]
    public float moveSpeed;

    [Header("Points")]
    public Transform spawnPoint;
    public Transform endOfLevel;
    public ParticleSystem particle;

    private void Start()
    {
        transform.position = spawnPoint.position;
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, endOfLevel.position, moveSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag != "Player" && collision.gameObject.tag != "Ground")
        {
            Destroy(collision.gameObject);
            particle.Play();
        }
    }
}
