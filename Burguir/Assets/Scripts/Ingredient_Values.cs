using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Ingredient_Values : MonoBehaviour
{
    public int calorias, grasas;
    public bool selected = false;
    public Nutritional_table n_table;
    public string panup, vegetal, proteina, pandown, salsas, termino;
    // Start is called before the first frame update
    void Start()
    {
        //n_table = GameObject.Find("Titulo").GetComponent<Nutritional_table>();
        ////Panes_Arriba
        //if (this.gameObject.name == "Pan_Up")
        //{
        //    calorias = 0;
        //    grasas = 100;
        //}
        //else if (this.gameObject.name == "Pan_Up_Light")
        //{
        //    calorias = 0;
        //    grasas = 50;
        //}
        //else if (this.gameObject.name == "Pan_Up_Heavy")
        //{
        //    calorias = 0;
        //    grasas = 200;
        //}
        ////Vegetales
        //else if (this.gameObject.name == "pepinillo")
        //{
        //    calorias = 0;
        //    grasas = 15;
        //}
        //else if (this.gameObject.name == "tomate")
        //{
        //    calorias = 0;
        //    grasas = 15;
        //}
        //else if (this.gameObject.name == "lechuga")
        //{
        //    calorias = 0;
        //    grasas = 3;
        //}
        ////Carnes
        //else if (this.gameObject.name == "res")
        //{
        //    calorias = 0;
        //    grasas = 15;
        //}
        //else if (this.gameObject.name == "cerdo")
        //{
        //    calorias = 0;
        //    grasas = 15;
        //}
        //else if (this.gameObject.name == "pollo")
        //{
        //    calorias = 0;
        //    grasas = 3;
        //}
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if(hit.collider == this.GetComponent<Collider>())
                {
                    if (selected == false)
                    {

                        selected = true;
                        //n_table.AddStat("statCalorias", this.calorias);
                        //if (this.gameObject.name == "res")
                        //{
                        //    n_table.panelTerminos.SetActive(true);
                        //}
                        if(this.gameObject.CompareTag("proteina"))
                        {
                            proteina = this.gameObject.name;
                            print(proteina);
                        }
                    }
                    else if (selected == true)
                    {
                        selected = false;
                        //n_table.RemoveStat("statCalorias", this.calorias);
                    }
                }
            }
        }
    }

    public void TerminoMedio()
    {
        
        proteina = proteina + " Termino medio";
        print(proteina);
    }

}
