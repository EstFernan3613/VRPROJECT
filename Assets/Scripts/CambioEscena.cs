using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{
    public void Jugar()
    {
        SceneManager.LoadScene("EscenaPrincipal", LoadSceneMode.Single);
    }

    public void Salir()
    {
        Application.Quit();
    }
}

