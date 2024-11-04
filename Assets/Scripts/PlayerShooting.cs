using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject laserPrefab; // Asigna el prefab del láser en el inspector
    public Transform firePoint; // Posición desde donde se dispara el láser
    private int score = 0; // Puntos del jugador

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(laserPrefab, firePoint.position, firePoint.rotation);
    }

    public void EnemyDestroyed()
    {
        score++;
        Debug.Log("Enemigos eliminados: " + score);
    }
}

