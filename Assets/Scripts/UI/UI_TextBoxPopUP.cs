using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_TextBoxPopUP : MonoBehaviour
{
    public GameObject textBox;
    public TMP_Text TMPObject;
    public string textLine;


    private void Start()
    {
        textBox.SetActive(false);
    }

    public void PopUp()
    {
        textBox.SetActive(true);
        TMPObject.text = textLine;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            PopUp();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        textBox.SetActive(false);
    }
}
