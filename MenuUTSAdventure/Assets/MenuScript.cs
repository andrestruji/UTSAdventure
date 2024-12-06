using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Jugar(string sceneJugar)
    {
        SceneManager.LoadScene(sceneJugar);
    }

    public void Salir(string sceneSalir)
    {
        SceneManager.LoadScene(sceneSalir);
    }

    public void CerrarJuego()
    {
        Application.Quit();
        Debug.Log("Saliste del juego!!!");
    }

}
