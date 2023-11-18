using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BowlScript : MonoBehaviour
{
    public GameObject cerealObject;
    public GameObject lecheObject;
    public GameObject frutaObject;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ColisionadorCereal"))
        {
            // Acciones a realizar cuando el cereal colisiona con el tazón
            // Por ejemplo, activar un objeto
            cerealObject.SetActive(true);
        }

        if (other.CompareTag("ColisionadorLeche"))
        {
            // Acciones a realizar cuando la leche colisiona con el tazón
            // Por ejemplo, activar un objeto
            lecheObject.SetActive(true);
        }

        if (other.CompareTag("ColisionadorFruta"))
        {
            // Acciones a realizar cuando la leche colisiona con el tazón
            // Por ejemplo, activar un objeto
            frutaObject.SetActive(true);
        }
    }
}
