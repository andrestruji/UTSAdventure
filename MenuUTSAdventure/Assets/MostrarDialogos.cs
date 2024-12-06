using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MostrarDialogos : MonoBehaviour
{
    public Text textoDialogo;          // Asigna el objeto de texto del Canvas
    public Text nombrePersonaje;       // Opcional: texto para el nombre del personaje
    private string[] dialogos = {
        "Hola, estas jugando UTSAdventure",
        "Tu priumer mision es recorrer el mapa",
        "¡GENIAL!"
    };
    private string[] nombres = {
        "Juan",
        "Miguelito",
        "Juan"
    };

    private int indice = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (indice < dialogos.Length)
            {
                nombrePersonaje.text = nombres[indice];
                textoDialogo.text = dialogos[indice];
                indice++;
            }
            else
            {
                textoDialogo.text = "Fin del dialogo.";
                nombrePersonaje.text = "";
            }
        }
    }
}
