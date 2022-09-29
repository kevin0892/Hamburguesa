using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Chef : MonoBehaviour
{
    public Selection[] productosSelec;

    public TMP_Text statCalorias;
    public TMP_Text stat_Grasas;
    public TMP_Text stat_Precios;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ActualizarDatos();
    }

    public void ActualizarDatos()
    {
        SingletonPrecio.instance.totalCal = 0;
        SingletonPrecio.instance.totalGrasas = 0;
        SingletonPrecio.instance.totalPrecio = 0;
        for(int i = 0; i < productosSelec.Length; i++)
        {
            Debug.Log("el producto es " + productosSelec[i].categoria + " y las calorias son "+ productosSelec[i].productoSeleccionado.calorias);
            SingletonPrecio.instance.totalCal += productosSelec[i].productoSeleccionado.calorias;
            SingletonPrecio.instance.totalGrasas += productosSelec[i].productoSeleccionado.grasas;
            SingletonPrecio.instance.totalPrecio += productosSelec[i].productoSeleccionado.precio;
        }

        statCalorias.text = SingletonPrecio.instance.totalCal.ToString();
        stat_Grasas.text = SingletonPrecio.instance.totalGrasas.ToString();
        //statCalorias.text = totalCal.ToString();
    }
}
