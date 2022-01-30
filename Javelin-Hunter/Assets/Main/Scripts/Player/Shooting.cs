using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    // Shooting variables
    public GameObject Projectile;
    public float ShootRate = 0.5f;


    void Update()
    {
        // Shooting
        if (Input.GetMouseButtonDown(0))
        {
            shoot();
        }
    }

    void shoot() // Player Shooting
    {
        GameObject projectile = Instantiate(Projectile, transform.position, transform.rotation);
    }
}
