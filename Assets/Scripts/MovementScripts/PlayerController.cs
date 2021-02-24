using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    [Header("Movement Variables")]
    public float moveSpeed;
    public float jumpForce;

    [Header("the bod")]
    private Rigidbody2D rb2D;

    [Header("Input Checks")]
    public float x;
    //public float y;

    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        x = Input.GetAxisRaw("Horizontal");
        //y = Input.GetAxisRaw("Vertical");

    }

}
