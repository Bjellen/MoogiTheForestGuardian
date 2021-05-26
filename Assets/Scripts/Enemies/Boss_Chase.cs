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

    private void Start()
    {
        transform.position = spawnPoint.position;
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, endOfLevel)
    }
}
