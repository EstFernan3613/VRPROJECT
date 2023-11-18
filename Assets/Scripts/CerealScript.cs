using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CerealScript : MonoBehaviour
{
    public ParticleSystem sistemaPar;

    private void Start()
    {
        // Obt�n la referencia al componente ParticleSystem
        sistemaPar = GetComponent<ParticleSystem>();
        // Aseg�rate de que el sistema de part�culas no est� reproduci�ndose al inicio
        sistemaPar.Stop();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ColisionadorBowl"))
        {
            // Acciones a realizar cuando el cereal colisiona con el taz�n
            // Por ejemplo, activar una animaci�n de part�culas
            sistemaPar.Play();
        }
    }
}
