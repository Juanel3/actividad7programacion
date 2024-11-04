using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFoll : MonoBehaviour
{
    public Transform player; // Asigna la nave del jugador en el inspector
    public Vector3 offset; // Ajusta este valor para posicionar la cámara adecuadamente

    void LateUpdate()
    {
        transform.position = player.position + offset;
        transform.LookAt(player);
    }
}

