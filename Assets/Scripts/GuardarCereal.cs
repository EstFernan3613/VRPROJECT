using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardarCereal: MonoBehaviour
{
    public bool cereal1;
    public bool cereal2;
    public bool cereal3;

    private void Awake()
    {
        cereal1 = PlayerPrefs.GetInt("cereal1Select") == 1;
        cereal2 = PlayerPrefs.GetInt("cereal2Select") == 1;
        cereal3 = PlayerPrefs.GetInt("cereal3Select") == 1;
    }

    private void Update()
    {
        if(cereal1 == false && cereal2 == false && cereal3 == false)
        {
            cereal1 = true;
        }
    }

    public void Cereal1()
    {
        cereal1 = true;
        cereal2 = false;
        cereal3 = false;
        Guardar();
    }

    public void Cereal2()
    {
        cereal1 = false;
        cereal2 = true;
        cereal3 = false;
        Guardar();
    }

    public void Cereal3()
    {
        cereal1 = false;
        cereal2 = false;
        cereal3 = true;
        Guardar();
    }

    public void Guardar()
    {
        PlayerPrefs.SetInt("cereal1Select", cereal1 ? 1 : 0);
        PlayerPrefs.SetInt("cereal2Select", cereal2 ? 1 : 0);
        PlayerPrefs.SetInt("cereal3Select", cereal3 ? 1 : 0);
    }
}
