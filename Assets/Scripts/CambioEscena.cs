using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{

    public GameObject funciones;

    public void Jugar()
    {
        SceneManager.LoadScene(1);
        funciones.GetComponent<GuardarCereal>().Guardar();
    }

    public void Salir()
    {
        Application.Quit();
    }

    public void MenuPrincipal()
    {
        SceneManager.LoadScene(0);
    }
}

