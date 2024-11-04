using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject explosionPrefab; // Prefab de explosión
    public int score = 0; // Puntos del jugador

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("EnemyLaser"))
        {
            Explode();
            Debug.Log("Enemigos eliminados: " + score);
        }
    }

    private void Explode()
    {
        Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        Destroy(gameObject); // Destruir la nave del jugador
    }

    public void EnemyDestroyed()
    {
        score++;
        Debug.Log("Enemigos eliminados: " + score);
    }
}

