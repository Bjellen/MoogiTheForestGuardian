using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CollectableUI : MonoBehaviour
{
    public int score;

   public TextMeshProUGUI CollectableCount;

    private void Start()
    {
        if (FindObjectsOfType<CollectableUI>().Length > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(this);
        }
    }

    void Update()
    {
        if (CollectableCount == null)
        {
            //CollectableCount = GameObject.FindGameObjectWithTag("CollectableText").GetComponent<TextMeshProUGUI>();
        }
        CollectableCount.text = "" + (FindObjectOfType<PlayerInputController>().Collectables);

        if(SceneManager.GetActiveScene().buildIndex == 0)
        {
           // Destroy(gameObject);
        }
    }
}