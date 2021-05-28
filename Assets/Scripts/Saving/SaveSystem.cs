using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SaveSystem : MonoBehaviour
{
    public SaveData data;
    string path => Application.persistentDataPath + "/saveData.json";


    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        Load();
    }


    [ContextMenu("Save")]
    public void Save()
    {

        string json = JsonUtility.ToJson(data);
        File.WriteAllText(path, json);

    }
    [ContextMenu("Load")]
    public void Load()
    {
        string json = File.ReadAllText(path);
        SaveData loadedData = JsonUtility.FromJson<SaveData>(json);

        data = loadedData;
    }
}

[System.Serializable]
public class SaveData
{
    //insert settings here when they are ready
    [Header("Settings")]
    public bool music;
    public bool sfx;
    public Vector3 spawn;

    [Space(10)]
    public bool[] levels;


    public SaveData(/*bool _music, bool _sfx,*/ bool[] _levels)
    {
        //this.music = _music;
        //this.sfx = _sfx;
        this.levels = _levels;

    }
}

