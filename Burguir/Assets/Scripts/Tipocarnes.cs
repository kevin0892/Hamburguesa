using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tipocarnes : MonoBehaviour
{
    public int TipodeCarne;
    // Start is called before the first frame update
    public void Siguiente()
    {
        TipodeCarne = (TipodeCarne + 1) % 4;
        PlayerPrefs.SetInt("Carne", TipodeCarne);
    }

    // Start is called before the first frame update
    public void Anterior()
    {
        TipodeCarne = (TipodeCarne + 3) % 4;
        PlayerPrefs.SetInt("Carne", TipodeCarne);
    }

    // Update is called once per frame
    void Start()
    {
        PlayerPrefs.SetInt("Carne", TipodeCarne);
    }
}
