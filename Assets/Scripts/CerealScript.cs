using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CerealScript : MonoBehaviour
{
    public ParticleSystem sistemaPar;

    private void Start()
    {
        // Obtén la referencia al componente ParticleSystem
        sistemaPar = GetComponent<ParticleSystem>();
        // Asegúrate de que el sistema de partículas no esté reproduciéndose al inicio
        sistemaPar.Stop();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ColisionadorBowl"))
        {
            // Acciones a realizar cuando el cereal colisiona con el tazón
            // Por ejemplo, activar una animación de partículas
            sistemaPar.Play();
        }
    }
}
