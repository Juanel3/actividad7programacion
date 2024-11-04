using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab; // Prefab del enemigo
    public float spawnInterval = 2f; // Intervalo entre spawns
    public float spawnDistance = 10f; // Distancia desde la nave del jugador
    public Transform player; // Asigna la nave del jugador en el inspector

    void Start()
    {
        InvokeRepeating("SpawnEnemy", 0f, spawnInterval);
    }

    void SpawnEnemy()
    {
        Vector3 spawnPosition = player.position + Vector3.forward * spawnDistance;
        spawnPosition.x = Random.Range(-5f, 5f); // Generar enemigos en un área a los lados
        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }
}
