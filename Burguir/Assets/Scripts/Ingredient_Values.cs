using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Ingredient_Values : MonoBehaviour
{
    public int calorias, grasas, precio;
    public bool selected = false;
    public Nutritional_table n_table;
    public Precios_table p_table;
    public string panup, vegetal, proteina, pandown, salsas, termino;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //void Update()
    //{
    //    if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
    //    {
    //        Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
    //        RaycastHit hit;

    //        if (Physics.Raycast(ray, out hit))
    //        {
    //            if(hit.collider == this.GetComponent<Collider>())
    //            {
    //                if (selected == false)
    //                {

    //                    selected = true;
                        
    //                    if(this.gameObject.CompareTag("proteina"))
    //                    {
    //                        proteina = this.gameObject.name;
    //                        print(proteina);
    //                    }
    //                }
    //                else if (selected == true)
    //                {
    //                    selected = false;
    //                    //n_table.RemoveStat("statCalorias", this.calorias);
    //                }
    //            }
    //        }
    //    }
    //}

    public void TerminoMedio()
    {
        
        termino = "Medio 2/4";
       
    }
    public void TerminoTresCuartos()
    {

        termino = "Tres Cuartos 3/4";
    }
    public void TerminoCompleto()
    {

        termino = "Hecho 4/4";
    }

}
