using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LecheScript : MonoBehaviour
{
    public AudioClip sonidoLeche;
    private AudioSource audioSource;

    private void Start()
    {
        // Obt�n la referencia al componente AudioSource
        audioSource = GetComponent<AudioSource>();
        // Aseg�rate de que el AudioSource no est� reproduci�ndose al inicio
        audioSource.Stop();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ColisionadorBowl"))
        {
            // Acciones a realizar cuando la leche colisiona con el taz�n
            // Por ejemplo, reproducir un sonido
            if (sonidoLeche != null)
            {
                audioSource.clip = sonidoLeche;
                audioSource.Play();
            }
        }
    }
}
