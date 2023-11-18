using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LecheScript : MonoBehaviour
{
    public AudioClip sonidoLeche;
    private AudioSource audioSource;

    private void Start()
    {
        // Obtén la referencia al componente AudioSource
        audioSource = GetComponent<AudioSource>();
        // Asegúrate de que el AudioSource no esté reproduciéndose al inicio
        audioSource.Stop();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ColisionadorBowl"))
        {
            // Acciones a realizar cuando la leche colisiona con el tazón
            // Por ejemplo, reproducir un sonido
            if (sonidoLeche != null)
            {
                audioSource.clip = sonidoLeche;
                audioSource.Play();
            }
        }
    }
}
