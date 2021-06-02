using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_TextBoxPopUP : MonoBehaviour
{
    public GameObject textBox;
    public TMP_Text TMPObject;
    public string[] textLines;
    public int textIndex;
    public int MaxtextIndex;

    private void Start()
    {
        textBox.SetActive(false);
    }

    public void PopUp()
    {
        textBox.SetActive(true);
        textIndex = 0;
        TMPObject.text = textLines[textIndex];
    }

    public void NextText()
    {
        textIndex+= 1;
        TMPObject.text = textLines[textIndex];

        if(textIndex == MaxtextIndex + 1)
        {
            textBox.SetActive(false);
        }
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
