using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AccionesCuchara : MonoBehaviour
{
    public GameObject efectoCucharaCereal;

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("CucharaCereal"))
        {
            efectoCucharaCereal.SetActive(true);
        }

        if (other.CompareTag("Boca") && transform.CompareTag("CucharaCereal"))
        {
            // Acciones a realizar cuando la cuchara con tag "CucharaCereal" colisiona con un objeto con tag "Boca"
            CargarSiguienteEscena();
        }
    }

    private void CargarSiguienteEscena()
    {
         SceneManager.LoadScene(3);
    }
}
