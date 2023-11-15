using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Gun : MonoBehaviour
{
    public XRGrabInteractable grabInteract;
    public Transform shootPoint;

    public DisparoRay disparo;

    public GameObject shootFX;

    bool act;

    float tiempoRestante;
    private float tiempoDisparo = 0.5f;


    // Start is called before the first frame update
    void Start()
    {
        grabInteract.activated.AddListener(x => Disparando());
        grabInteract.deactivated.AddListener(x => DejarDisparo());

        tiempoRestante = tiempoDisparo;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (tiempoRestante > tiempoDisparo)
        {
            tiempoRestante -= Time.deltaTime;
        }
        
    }

    public void Disparando()
    {
        Debug.Log("Disparando");

        tiempoRestante = tiempoDisparo;
        act = true;

        Instantiate(shootFX, shootPoint.position, shootPoint.rotation);
        disparo.Disparar(act);
    }

    public void DejarDisparo()
    {
        Debug.Log("Disparandont");
        //gun.Stop(true, ParticleSystemStopBehaviour.StopEmitting);
        act = false;
    }
}