using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] private float tiempoMaximo;

    [SerializeField] private Slider slider;

    private float tiempoActual;

    private bool tiempoActivado = false;


    private void Start()
    {
        ActivarTemporizador();
    }

    // Update is called once per frame
    private void Update()
    {
        if (tiempoActivado)
        {
            CambiarContador();
        }
    }

    private void CambiarContador()
    {
        tiempoActual -= Time.deltaTime;

        if (tiempoActual >= 0)
        {
            slider.value = tiempoActual;
        }


        if (tiempoActual <= 0)
        {
            Debug.Log("Derrota");
            CambiarTemporizador(false);
            SceneManager.LoadScene(2);

        }
    }

    private void CambiarTemporizador(bool estado)
    {
        tiempoActivado = estado;
    }

    public void ActivarTemporizador()
    {
        tiempoActual = tiempoMaximo;
        slider .maxValue = tiempoMaximo;
        CambiarTemporizador(true);
    }

    public void DesactivarTemporizador()
    {
        CambiarTemporizador(false);
    }
}
