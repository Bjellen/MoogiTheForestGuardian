using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioClip : MonoBehaviour
{
    private AudioSource source;
    public AudioClip[] clips;
    public float pitchMin, pitchMax;

    public void PlayAudio()
    {
        source.clip = clips[Random.Range(0, clips.Length)];
        source.pitch = Random.Range(pitchMin, pitchMax);
        source.Play();
    }
    private void Awake()
    {
        source = GetComponent<AudioSource>();
    }
}
