using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Nutritional_table : MonoBehaviour
{
    public int _qtty;
    public TMP_Text statCalorias;
    public TMP_Text stat_Grasas;
    public GameObject panelTerminos;
    public GameObject panelTable;
    public Chef chef;
    // Start is called before the first frame update
    void Start()
    {
        if (panelTerminos == null)
        {
            panelTerminos = GameObject.Find("Panel_Terminos");
            panelTerminos.SetActive(false);
        }

        if (panelTable == null)
        {
            panelTable = GameObject.Find("Nutritional_Panel");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        statCalorias.text = SingletonPrecio.instance.totalCal.ToString();
        stat_Grasas.text = SingletonPrecio.instance.totalGrasas.ToString();
    }

    public void ClosePanelTerminos()
    {
        panelTerminos.SetActive(false);
    }

    public void PagoScene()
    {
        string name = chef.productosSelec[1].productoSeleccionado.name;
        if (name == "res")
        {
            
            panelTerminos.SetActive(true);
        }
        else
        {
            SceneManager.LoadScene("Pago");
        }
        
    }

    public void OpenPanelTable()
    {
        panelTable.SetActive(true);
    }
    public void ClosePanelTable()
    {
        panelTable.SetActive(false);
    }

}
