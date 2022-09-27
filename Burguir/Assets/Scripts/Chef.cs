using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Chef : MonoBehaviour
{
    public Selection[] productosSelec;

    public int totalCal, totalGrasas, totalPrecio;
    public TMP_Text statCalorias;
    public TMP_Text stat_Grasas;
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
        totalCal = 0;
        totalGrasas = 0;
        totalPrecio = 0;
        for(int i = 0; i < productosSelec.Length; i++)
        {
            totalCal += productosSelec[i].productoSeleccionado.calorias;
            totalGrasas += productosSelec[i].productoSeleccionado.grasas;
            totalPrecio += productosSelec[i].productoSeleccionado.precio;
        }

        statCalorias.text = totalCal.ToString();
        stat_Grasas.text = totalGrasas.ToString();
        //statCalorias.text = totalCal.ToString();
    }
}
