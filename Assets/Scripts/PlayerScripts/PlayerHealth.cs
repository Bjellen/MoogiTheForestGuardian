using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [Header("Player Healths")]
    public int playerHealth = 3;

    [Header("What hurts player")]
    public string dangerTag;

    [Header("What scene to load when;")]
    public string deathScene;

    [Header("Spawnpoints")]
    public Transform spawnPoint;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(dangerTag) == true)
        {
            TakeDamage();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(dangerTag) == true)
        {
            TakeDamage();
        }
    }

    void TakeDamage()
    {
        playerHealth -= 1;
        transform.position = spawnPoint.transform.position;
        Debug.Log("I have taken damage");

        if(playerHealth <= 0)
        {
            Debug.Log("I have died");
            //Die();
        }
    }

    void Die()
    {
        SceneManager.LoadScene(deathScene);
    }
}
