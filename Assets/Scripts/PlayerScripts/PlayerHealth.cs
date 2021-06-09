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
    public CheckMaster cm;

    [Header("Boss")]
    public Boss_Chase boss;

    private void Start()
    {
        cm = GameObject.FindGameObjectWithTag("CM").GetComponent<CheckMaster>();

        //If no Boss, boss is null
        if (GameObject.FindGameObjectsWithTag("Boss").Length != 0)
        { boss = GameObject.FindGameObjectWithTag("Boss").GetComponent<Boss_Chase>(); }

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
            BossDie();
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
            Die();
        }
    }

    void Die()
    {
        
        transform.position = cm.lastCheckPointPos[cm.checkPointIndex].transform.position;

        playerHealth = 3;

    }

    void BossDie()
    {
        SceneManager.LoadScene(deathScene);

    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(knockBackTime);
        knockBack = false;
    }
}
