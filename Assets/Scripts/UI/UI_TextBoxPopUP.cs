using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_TextBoxPopUP : MonoBehaviour
{
    public GameObject textBox;
    public TMP_Text TMPObject;
    public string textLine;
    private Animator anim;

    private void Start()
    {
        textBox.SetActive(false);
        anim = GetComponentInParent<Animator>();
    }

    public void PopUp()
    {
        textBox.SetActive(true);
        TMPObject.text = textLine;
        anim.SetBool("IsTalking", true);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            PopUp();
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PopUp();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        textBox.SetActive(false);
        anim.SetBool("IsTalking", false);
    }
}
