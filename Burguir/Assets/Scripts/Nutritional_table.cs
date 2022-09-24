using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Nutritional_table : MonoBehaviour
{
    public int _qtty;
    public TMP_Text statCalorias;
    public TMP_Text stat_Grasas;
    public GameObject panelTerminos;
    // Start is called before the first frame update
    void Start()
    {
        if (panelTerminos == null)
        {
            panelTerminos = GameObject.Find("Panel_Terminos");
            panelTerminos.SetActive(false);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddStat(string stat, int qtty)
    {
        if (stat == "statCalorias") {
            _qtty += qtty;
            statCalorias.text = _qtty.ToString();
        }
    }
    public void RemoveStat(string stat, int qtty)
    {
        if (stat == "statCalorias")
        {
            _qtty -= qtty;
            statCalorias.text = _qtty.ToString();
        }
    }

    public void ResetStat(string stat)
    {
        _qtty = 0;
        statCalorias.text = _qtty.ToString();
    }

    public void ClosePanelTerminos()
    {
        panelTerminos.SetActive(false);
    }
}
public class Precios_table : MonoBehaviour
{
    public int _qtty;
    public TMP_Text statCalorias;
    public TMP_Text stat_Grasas;
    public TMP_Text stat_Precios;
    public GameObject panelTerminos;
    // Start is called before the first frame update
    void Start()
    {
        if (panelTerminos == null)
        {
            panelTerminos = GameObject.Find("Panel_Terminos");
            panelTerminos.SetActive(false);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddStat(string stat, int qtty)
    {
        if (stat == "stat_Precios")
        {
            _qtty += qtty;
            stat_Precios.text = _qtty.ToString();
        }
    }
    public void RemoveStat(string stat, int qtty)
    {
        if (stat == "stat_Precios")
        {
            _qtty -= qtty;
            stat_Precios.text = _qtty.ToString();
        }
    }

    public void ResetStat(string stat)
    {
        _qtty = 0;
        stat_Precios.text = _qtty.ToString();
    }

    public void ClosePanelTerminos()
    {
        panelTerminos.SetActive(false);
    }
}