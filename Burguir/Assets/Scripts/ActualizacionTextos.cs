using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ActualizacionTextos : MonoBehaviour
{
    public TMP_Text stat_Precios;
    public TMP_Text stat_Preciosiva;
    public TMP_Text IVA;
    public GameObject pagoPopup;
    public Chef chef;
    public PostMethod postData;
    public TMP_Text pan_sup, proteina, vegetales, pan_inf, salsas;
    // Start is called before the first frame update

    private void Start()
    {
        pagoPopup.SetActive(false);
    }
    public void UpdateTexts()
    {
        if (pagoPopup.activeInHierarchy == false)
        {
            pagoPopup.SetActive(true);
            
        }
        UpdateProductDesc();
        stat_Precios.text = "$ "+ (SingletonPrecio.instance.totalPrecio).ToString("N0");
        stat_Preciosiva.text = "$ " + (SingletonPrecio.instance.totalPrecio * 1.19).ToString("N0");
        IVA.text = "$ " + (SingletonPrecio.instance.totalPrecio * 0.19).ToString("N0");
    }

    public void ClosePopup()
    {
        if(pagoPopup.activeInHierarchy == true)
        {
            pagoPopup.SetActive(false);
        }
    }

    

    public void UpdateProductDesc()
    {
        pan_sup.text = postData.productosSelec[0].productoSeleccionado.name;   
        proteina.text = postData.productosSelec[1].productoSeleccionado.name;
        pan_inf.text =  postData.productosSelec[2].productoSeleccionado.name;
        if(postData.vegetales == "" || postData.vegetales == null)
        {
            vegetales.text = "Sin vegetales";
        }
        else
        {
            vegetales.text = postData.vegetales.ToString();
        }
        if (postData.salsas == "" || postData.salsas == null)
        {
            salsas.text = "Sin salsas";
        }
        else
        {
            salsas.text = postData.salsas.ToString();
        }

       
    }
}
