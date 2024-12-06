using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraSeguidora : MonoBehaviour
{
    public Transform objetivo; // Arrástra aquí el objeto que quieres seguir (el personaje)
    public float distancia = 5f;
    public float altura = 3f;

    void LateUpdate()
    {
        Vector3 posicion = objetivo.position;
        posicion.y += altura;
        transform.position = posicion - transform.forward * distancia;
    }
}
