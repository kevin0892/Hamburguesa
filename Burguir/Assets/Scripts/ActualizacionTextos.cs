using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ActualizacionTextos : MonoBehaviour
{
    public TMP_Text stat_Precios;
    // Start is called before the first frame update
    void Start()
    {
        stat_Precios.text = "$ "+ SingletonPrecio.instance.totalPrecio;
    }
}
