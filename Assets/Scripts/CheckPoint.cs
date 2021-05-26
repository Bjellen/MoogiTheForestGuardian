using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    private CheckMaster cm;
    public ParticleSystem particle;

    void Start()
    {
        cm = GameObject.FindGameObjectWithTag("CM").GetComponent<CheckMaster>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player") && cm.lastCheckPointPos != (Vector2)transform.position)
        {
            cm.lastCheckPointPos = transform.position;
            particle.Play();
        }
    }
}
