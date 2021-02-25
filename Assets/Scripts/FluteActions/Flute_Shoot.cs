using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flute_Shoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float bulletVelocity;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject _bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D _bulletRb = _bullet.GetComponent<Rigidbody2D>();
        _bulletRb.velocity = _bullet.transform.right * bulletVelocity;
    }
}
