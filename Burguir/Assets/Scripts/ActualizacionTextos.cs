using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ActualizacionTextos : MonoBehaviour
{
    public TMP_Text stat_Precios;
    public TMP_Text stat_Preciosiva;
    public TMP_Text IVA;
    // Start is called before the first frame update
    void Start()
    {
        stat_Precios.text = "$ "+ (SingletonPrecio.instance.totalPrecio).ToString("N0");
        stat_Preciosiva.text = "$ " + (SingletonPrecio.instance.totalPrecio * 1.19).ToString("N0");
        IVA.text = "$ " + (SingletonPrecio.instance.totalPrecio * 0.19).ToString("N0");
    }
}
