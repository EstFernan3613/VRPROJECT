using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrutaScript : MonoBehaviour
{
    public GameObject objetoExterno;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ColisionadorBowl"))
        {
            // Acciones a realizar cuando la fruta entra en contacto con el tazón
            // Por ejemplo, destruir la fruta y un objeto externo
            DestruirFruta();
        }
    }

    private void DestruirFruta()
    {
        // Destruye la fruta
        Destroy(gameObject);

        // Verifica si hay un objeto externo asignado
        if (objetoExterno != null)
        {
            // Destruye el objeto externo
            Destroy(objetoExterno);
        }
    }
}
