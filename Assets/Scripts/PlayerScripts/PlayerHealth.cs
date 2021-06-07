using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public Transform PlayerTransform;
    public Transform EnemyTransform;
    public Rigidbody2D PlayerRB;

    public float knockbackStrength;

    public bool knockBack;
    public float knockBackTime;

    [Header("Player Healths")]
    public int playerHealth = 3;

    [Header("What hurts player")]
    public string dangerTag;
    public string killTag;
    public string bossTag;

    [Header("What scene to load when;")]
    public string deathScene;

    [Header("Spawnpoints")]
    public Transform spawnPoint;

    private void Start()
    {
        PlayerRB = GetComponent<Rigidbody2D>();
        playerHealth = 3;
        PlayerTransform = GetComponent<Transform>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(dangerTag) == true)
        {
            EnemyTransform = collision.collider.GetComponent<Transform>();
            knockBack = true;
            TakeDamage();
        }

        if (collision.gameObject.CompareTag(killTag))
        {
            Die();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(dangerTag) == true)
        {
            TakeDamage();
        }

        if (collision.gameObject.CompareTag(killTag))
        {
            Die();
        }

        if (collision.gameObject.CompareTag(bossTag))
        {
            Die();
        }
    }

    void TakeDamage()
    {
        playerHealth -= 1;
        Debug.Log("I have taken damage");

        Vector2 _direction = EnemyTransform.transform.position - PlayerTransform.position;
        _direction.y = 0;
        Debug.Log(-_direction.normalized*knockbackStrength);

        PlayerRB.velocity = new Vector2(-_direction.x * knockbackStrength, -_direction.y);
        StartCoroutine("Wait");


        if (playerHealth <= 0)
        {
            Debug.Log("I have died");
            knockBack = false;
            PlayerTransform.position = spawnPoint.transform.position;
            //Die();
        }
    }

    void Die()
    {
        SceneManager.LoadScene(deathScene);
        Debug.Log("I am dead");
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(knockBackTime);
        knockBack = false;
    }
}
