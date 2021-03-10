using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Enemy_Walk : MonoBehaviour
{
    private Rigidbody2D enemyRb;

    [Header("Movement")]
    public float moveSpeed;

    [Header("Movement Vectors")]
    public Vector2[] moveDirections;
    public int directionIndex;
    [Tooltip ("Be the amount of movedirections the MoveDirection array says")]
    public int MaxDirectionIndex;

    private bool changeDir;

    private void Start()
    {
        enemyRb = GetComponent<Rigidbody2D>();

        directionIndex = 0;

        InvokeRepeating("SwitchDirection", 2, 2);
    }

    private void Update()
    {
        if (changeDir == true)
        {
            ChangeDirection();

            changeDir = false;
        }

        if (directionIndex == 2) { Flip(); }

        if (directionIndex >= MaxDirectionIndex)
        {
            FlipBack();
            directionIndex = 0;
        }

        if(gameObject.tag == "Friend")
        {
            CancelInvoke("SwitchDirection");
            gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
        }
    }

    private void FixedUpdate()
    {
        enemyRb.velocity = moveDirections[directionIndex] * moveSpeed;
    }

    #region ChangeDirection functions
    void ChangeDirection()
    {
        directionIndex++;
    }

    void SwitchDirection()
    {
        if(changeDir) { changeDir = false; }
        else { changeDir = true; }
    }
    #endregion

    #region Flip functions
    void Flip()
    {
        transform.rotation = Quaternion.Euler(0, 180, 0);
    }
    
    void FlipBack()
    {
        transform.rotation = Quaternion.Euler(0, 0, 0);
    }
    #endregion
}
