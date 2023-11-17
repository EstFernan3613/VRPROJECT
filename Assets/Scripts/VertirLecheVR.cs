using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ServirLecheVR : XRGrabInteractable
{
    // Variable para controlar si se está vertiendo leche
    private bool vertiendoLeche = false;

    // Rotación mínima para iniciar la acción de verter leche
    private float rotacionMinimaParaVerter = 90f;

    // Método llamado cuando se inicia la interacción
    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        // Iniciar la acción de verter leche si la rotación en Z es mayor de 90 grados
        if (transform.rotation.eulerAngles.z > rotacionMinimaParaVerter)
        {
            vertiendoLeche = true;

            // Lógica adicional, como reproducir sonidos o activar partículas
            // Ejemplo: GetComponent<ParticleSystem>().Play();
        }
    }

    // Método llamado cuando se termina la interacción
    protected override void OnSelectExited(SelectExitEventArgs args)
    {
        // Detener la acción de verter leche
        vertiendoLeche = false;

        // Lógica adicional, como detener sonidos o desactivar partículas
        // Ejemplo: GetComponent<ParticleSystem>().Stop();
    }

    // Método para simular el vertido de leche
    private void VerterLeche()
    {
        // Implementa la lógica para verter leche aquí
        // Puedes utilizar transformaciones para cambiar la posición del líquido o ajustar el tamaño del objeto, según tu diseño.
    }

    // Actualización del juego
    private void Update()
    {
        // Si se está vertiendo leche, llama al método para simular el vertido
        if (vertiendoLeche)
        {
            VerterLeche();
        }
    }
}
