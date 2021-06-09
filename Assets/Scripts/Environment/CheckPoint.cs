using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    private CheckMaster cm;
    public ParticleSystem particle;
    public int maxAmountOfCheckpoints;

    void Start()
    {
        cm = GameObject.FindGameObjectWithTag("CM").GetComponent<CheckMaster>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            cm.checkPointIndex += 1 ;

            if(cm.checkPointIndex == maxAmountOfCheckpoints + 1)
            { cm.checkPointIndex = 0; }

            particle.Play();
            GetComponentInChildren<PlayAudioClip>().PlayAudio(); 
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        GetComponent<BoxCollider2D>().enabled = false;
    }
}
