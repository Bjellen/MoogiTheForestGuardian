using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEnd : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        FindObjectOfType<CollectableUI>().score = FindObjectOfType<PlayerInputController>().Collectables;
        FindObjectOfType<PlayerInputController>().Collectables = 0;
    }
}
