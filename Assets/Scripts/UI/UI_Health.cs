using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Health : MonoBehaviour
{
    public PlayerHealth healthVar;
    public int numberOfHearts;

    public Image[] Hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    private void Awake()
    {
        healthVar = GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<PlayerHealth>();
    }

    void Update()
    {
        if(healthVar.playerHealth > numberOfHearts)
        {
            healthVar.playerHealth = numberOfHearts;
        }

        for(int i = 0; i < Hearts.Length; i++)
        {
            if(i < healthVar.playerHealth) { Hearts[i].sprite = fullHeart; }
            else { Hearts[i].sprite = emptyHeart; }

            if(i < numberOfHearts) { Hearts[i].enabled = true; }
            else { Hearts[i].enabled = false; }
        }
    }
}
