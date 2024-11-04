using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveMovement : MonoBehaviour
{
    public float speed = 10f;
    public float boundary = 5f; // Limite del movimiento en el eje X

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Movimiento
        transform.Translate(new Vector3(horizontalInput, verticalInput, 0) * speed * Time.deltaTime);

        // Limitar el movimiento
        Vector3 clampedPosition = transform.position;
        clampedPosition.x = Mathf.Clamp(clampedPosition.x, -boundary, boundary);
        clampedPosition.y = Mathf.Clamp(clampedPosition.y, -boundary, boundary);
        transform.position = clampedPosition;
    }
}

