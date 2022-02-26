using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Canvas_ImageSize : MonoBehaviour
{
    private Image myImage;

    void Update()
    {
    myImage.SetNativeSize();  
    }
}
