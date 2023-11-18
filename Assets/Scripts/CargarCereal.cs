using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CargarCereal : MonoBehaviour
{
    public GameObject cereal1Seleccionado;
    public GameObject cereal2Seleccionado;
    public GameObject cereal3Seleccionado;

    public bool cereal1;
    public bool cereal2;
    public bool cereal3;

    private void Update()
    {
        cereal1 = PlayerPrefs.GetInt("cereal1Select") == 1;
        cereal2 = PlayerPrefs.GetInt("cereal2Select") == 1;
        cereal3 = PlayerPrefs.GetInt("cereal3Select") == 1;

        if(cereal1 == true)
        {
            cereal1Seleccionado.SetActive(true);
            Destroy(cereal2Seleccionado);
            Destroy(cereal3Seleccionado);
        }

        if (cereal2 == true)
        {
            cereal2Seleccionado.SetActive(true);
            Destroy(cereal1Seleccionado);
            Destroy(cereal3Seleccionado);
        }

        if (cereal3 == true)
        {
            cereal3Seleccionado.SetActive(true);
            Destroy(cereal2Seleccionado);
            Destroy(cereal1Seleccionado);
        }
    }
}
