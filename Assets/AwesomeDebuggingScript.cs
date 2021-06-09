using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AwesomeDebuggingScript : MonoBehaviour
{
    public GameObject player;
    public CheckMaster cm;
    #region basic stuff
    public Text txt;
    private void Awake()
    {
        txt = GetComponent<Text>();
    }
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = "Checkpoint Index is  " + cm.checkPointIndex;
    }
}
