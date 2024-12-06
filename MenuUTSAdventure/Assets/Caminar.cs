using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caminar : MonoBehaviour
{
    public CharacterController controller;
    public Animator animator; // Referencia al Animator para controlar las animaciones
    public float speed = 20f;
    public float rotationSpeed = 45f; // Grados por segundo

    void Update()
    {
        float x = Input.GetAxis("Horizontal"); // A/D o flechas izquierda/derecha
        float z = Input.GetAxis("Vertical"); // W/S o flechas arriba/abajo

        Vector3 move = transform.right * x + transform.forward * z;

        // Si el vector de movimiento no es cero, rota hacia la direcci�n de movimiento
        if (move != Vector3.zero)
        {
            // Calcula la rotaci�n deseada basada en la direcci�n de movimiento
            Quaternion targetRotation = Quaternion.LookRotation(move);

            // Rota suavemente hacia la rotaci�n deseada
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

            // Activa la animaci�n de giro cuando el personaje gire
            if (x != 0) // Si se mueve hacia la derecha o izquierda (horizontal)
            {
                animator.SetTrigger("isTurning"); // Activa el trigger de la animaci�n de giro
            }
        }

        // Mueve el personaje
        controller.Move(move * speed * Time.deltaTime);
    }
}
