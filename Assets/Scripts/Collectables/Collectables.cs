using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables : MonoBehaviour
{
    private PlayAudioClip audio;
    private void Awake()
    {
        audio = GameObject.FindGameObjectWithTag("CollectableAudio").GetComponent<PlayAudioClip>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        var player = other.GetComponent<PlayerInputController>();
        if (player != null)
        {
            player.Collectables++;
            FindObjectOfType<CollectableUI>().score++;
            audio.PlayAudio();
            Destroy(gameObject);
        }
    }
}
