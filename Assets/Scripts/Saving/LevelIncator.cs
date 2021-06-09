using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelIncator : MonoBehaviour
{
    public PlayerInputController player;

    public int levelNr;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<PlayerInputController>();
    }

    private void Start()
    {
        player.movementIndex = levelNr;
    }

    
}
