using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ingredient_Values : MonoBehaviour
{
    public int calorias, grasas;
    public bool selected = false;
    public Nutritional_table n_table;
    // Start is called before the first frame update
    void Start()
    {
        n_table = GameObject.Find("Titulo").GetComponent<Nutritional_table>();
        if (this.gameObject.name == "Pan_Up")
        {
            calorias = 100;
            grasas = 100;
        }
        else if (this.gameObject.name == "Pan_Up_Light")
        {
            calorias = 50;
            grasas = 50;
        }
        else if (this.gameObject.name == "Pan_Up_Heavy")
        {
            calorias = 200;
            grasas = 200;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        if (selected==false)
        {
           
            selected = true;
            n_table.AddStat("statCalorias", this.calorias);
        }
        else if(selected == true)
        {
            selected = false;
            n_table.RemoveStat("statCalorias", this.calorias);
        }
        
    }
}
