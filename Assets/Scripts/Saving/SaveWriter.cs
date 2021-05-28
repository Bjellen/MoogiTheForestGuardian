using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveWriter : MonoBehaviour
{
    public SaveSystem saveSystem;
    public int levelNr;

    private void Awake()
    {
        saveSystem = GameObject.FindGameObjectWithTag("SaveSystem").GetComponent<SaveSystem>();

    }
    private void Start()
    {
        saveSystem.data.levels[levelNr] = true;
        saveSystem.Save();
        
    }
}
