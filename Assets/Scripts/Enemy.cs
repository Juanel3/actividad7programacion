using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject laserPrefab; // Prefab del láser del enemigo
    public Transform firePoint; // Punto desde donde el enemigo dispara
    public float speed = 3f;
    public float shootingInterval = 3f; // Intervalo entre disparos

    private void Start()
    {
        InvokeRepeating("Shoot", shootingInterval, shootingInterval);
    }

    private void Update()
    {
        // Moverse hacia el jugador
        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }

    private void Shoot()
    {
        Instantiate(laserPrefab, firePoint.position, firePoint.rotation);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Laser"))
        {
            Destroy(other.gameObject); // Destruir el láser
            Explode();
            Destroy(gameObject); // Destruir el enemigo
        }
    }

    private void Explode()
    {
        // Implementa el sistema de partículas de explosión aquí
        // Instantiate(explosionPrefab, transform.position, Quaternion.identity);
    }
}
