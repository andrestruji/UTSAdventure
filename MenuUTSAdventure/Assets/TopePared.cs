using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopePared : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Moneda")
        {
            Debug.Log("Has tocado una moneda!");
            // Aquí puedes agregar tu lógica para recoger la moneda, etc.
        }
    }
}