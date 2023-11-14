using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class DisparoRay : MonoBehaviour
{

    public Transform firePoint;
    public int damage = 25;

    public LineRenderer lineRenderer;

    private float tiempoDisparo = 0.5f;
    private float tiempoRestante;

    public GameObject impact;

    //public Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        //anim = GetComponent<Animator>();
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

    public void Disparar(bool disp)
    {
        if ( tiempoRestante <= 0 && disp)
        {
            StartCoroutine(Disparo());
        }

        if (!disp)
        {

        }
    }

    IEnumerator Disparo()
    {
        RaycastHit hit;
        bool hitInfo = Physics.Raycast(firePoint.position, firePoint.forward, out hit, 50f);

        if (hitInfo)
        {
            lineRenderer.SetPosition(0, firePoint.position);
            lineRenderer.SetPosition(1, hit.point);

            Instantiate(impact, hit.point, Quaternion.identity);
        }
        else
        {
            lineRenderer.SetPosition(0, firePoint.position);
            lineRenderer.SetPosition(1, firePoint.position + firePoint.forward * 20);
        }

        lineRenderer.enabled = true;

        yield return new WaitForSeconds(0.02f);

        lineRenderer.enabled = false;
    }
}
