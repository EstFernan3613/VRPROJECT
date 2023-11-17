using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ServirLecheVR : XRGrabInteractable
{
    // Variable para controlar si se est� vertiendo leche
    private bool vertiendoLeche = false;

    // Rotaci�n m�nima para iniciar la acci�n de verter leche
    private float rotacionMinimaParaVerter = 90f;

    // M�todo llamado cuando se inicia la interacci�n
    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        // Iniciar la acci�n de verter leche si la rotaci�n en Z es mayor de 90 grados
        if (transform.rotation.eulerAngles.z > rotacionMinimaParaVerter)
        {
            vertiendoLeche = true;

            // L�gica adicional, como reproducir sonidos o activar part�culas
            // Ejemplo: GetComponent<ParticleSystem>().Play();
        }
    }

    // M�todo llamado cuando se termina la interacci�n
    protected override void OnSelectExited(SelectExitEventArgs args)
    {
        // Detener la acci�n de verter leche
        vertiendoLeche = false;

        // L�gica adicional, como detener sonidos o desactivar part�culas
        // Ejemplo: GetComponent<ParticleSystem>().Stop();
    }

    // M�todo para simular el vertido de leche
    private void VerterLeche()
    {
        // Implementa la l�gica para verter leche aqu�
        // Puedes utilizar transformaciones para cambiar la posici�n del l�quido o ajustar el tama�o del objeto, seg�n tu dise�o.
    }

    // Actualizaci�n del juego
    private void Update()
    {
        // Si se est� vertiendo leche, llama al m�todo para simular el vertido
        if (vertiendoLeche)
        {
            VerterLeche();
        }
    }
}
