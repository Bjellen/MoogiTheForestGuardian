using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flute_BulletScript : MonoBehaviour
{
    public float timeUntilDeath;
    private IEnumerator Start()
    {
        yield return new WaitForSecondsRealtime(timeUntilDeath);
        Destroy(gameObject);
    }
}
