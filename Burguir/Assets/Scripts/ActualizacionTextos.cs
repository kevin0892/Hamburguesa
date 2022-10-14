using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ActualizacionTextos : MonoBehaviour
{
    public TMP_Text stat_Precios;
    public TMP_Text stat_Preciosiva;
    // Start is called before the first frame update
    void Start()
    {
        stat_Precios.text = "$ "+ SingletonPrecio.instance.totalPrecio;
        stat_Preciosiva.text = "$ " + SingletonPrecio.instance.totalPrecio * 1.19;
    }
}
