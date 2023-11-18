using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarTagCuchara : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("Cuchara") && other.CompareTag("CerealCompleto"))
        {
            // Cambia el tag de la cuchara a "CucharaCereal"
            gameObject.tag = "CucharaCereal";
        }
    }
}
