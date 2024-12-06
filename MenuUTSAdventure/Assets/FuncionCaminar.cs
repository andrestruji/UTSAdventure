using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorPersonaje : MonoBehaviour
{
    public Animator animator; // Referencia al componente Animator

    void Update()
    {
        // Si se presiona la tecla hacia adelante, se activa el parámetro "Walking"
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("Walking", true);
        }
        else
        {
            animator.SetBool("Walking", false);
        }
    }
}
