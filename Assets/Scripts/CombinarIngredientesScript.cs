using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CombinarIngredientesScript : MonoBehaviour
{
    public GameObject lecheObject;
    public GameObject cerealObject;
    public GameObject frutaObject;
    public AudioClip sonidoCombinacion;

    private bool ingredientesCombinados = false;
    private AudioSource audioSource;

    private void Start()
    {
        // Obtén la referencia al componente AudioSource
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        // Verifica si ambos ingredientes están activos al mismo tiempo
        if (lecheObject.activeSelf && cerealObject.activeSelf && frutaObject.activeSelf && !ingredientesCombinados)
        {
            // Acciones a realizar cuando ambos ingredientes están activos al mismo tiempo
            // Por ejemplo, reproducir un sonido y cambiar el tag del objeto
            if (sonidoCombinacion != null)
            {
                audioSource.clip = sonidoCombinacion;
                audioSource.Play();
            }

            ingredientesCombinados = true; // Evita que se repita esta acción
            CambiarTag();
        }
    }

    private void CambiarTag()
    {
        // Cambia el tag del objeto que posee este script a "CerealCompleto"
        gameObject.tag = "CerealCompleto";
    }
}
