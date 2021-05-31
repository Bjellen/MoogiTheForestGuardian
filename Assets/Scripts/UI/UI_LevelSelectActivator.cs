using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_LevelSelectActivator : MonoBehaviour
{
    public SaveSystem saveSystem;

    public GameObject[] Levels;

    private void Awake()
    {
        saveSystem = GameObject.FindGameObjectWithTag("SaveSystem").GetComponent<SaveSystem>();
        Levels[0].SetActive(false);
        Levels[1].SetActive(false);
        Levels[2].SetActive(false);
        Levels[3].SetActive(false);
        Levels[4].SetActive(false);
        Levels[5].SetActive(false);
    }

    private void Update()
    {
        if (saveSystem.data.levels[0])
        { Levels[0].SetActive(true); }
        else { Levels[0].SetActive(false); }

        if (saveSystem.data.levels[1])
        { Levels[1].SetActive(true); }
        else  { Levels[1].SetActive(false); }

        if (saveSystem.data.levels[2])
        { Levels[2].SetActive(true); }
        else { Levels[2].SetActive(false); }

        if (saveSystem.data.levels[3])
        { Levels[3].SetActive(true); }
        else { Levels[3].SetActive(false); }

        if (saveSystem.data.levels[4])
        { Levels[4].SetActive(true); }
        else  {  Levels[4].SetActive(false); }

        if (saveSystem.data.levels[5])
        { Levels[5].SetActive(true); }
        else  { Levels[5].SetActive(false); }
    }
}
