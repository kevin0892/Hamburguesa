using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using TMPro;
 
public class PostMethod : MonoBehaviour
{
    // public TMP_InputField outputArea;
    public Nutritional_table n_table;
    public Ingredient_Values terminosData;
    public Vegetables vegetablesSelec;
    public Selection[] productosSelec;
    public string pan_up, proteina, vegetales, pan_down, salsas;
    public ActualizacionTextos popupManager;
 
    void Start()
    {
        Debug.Log("hola");
        //outputArea = GameObject.Find("OutputArea").GetComponent<TMP_InputField>();
        //GameObject.Find("btn_Crear").GetComponent<Button>().onClick.AddListener(PostData);
        terminosData = GameObject.Find("TerminosController").GetComponent<Ingredient_Values>();
        n_table = GameObject.Find("Panel_Manager").GetComponent<Nutritional_table>();
    }

    private void Update()
    {
        //print("hola" + SingletonPrecio.instance.totalPrecio);
    }

    public void OpenPagoPopup()
    {
        if (vegetablesSelec != null)
        {
            if (vegetablesSelec.conLechuga == true && vegetablesSelec.conPepinillos == false && vegetablesSelec.conTomate == false)
            {
                vegetales = "Lechuga";
            }
            else if (vegetablesSelec.conLechuga == true && vegetablesSelec.conPepinillos == true && vegetablesSelec.conTomate == false)
            {
                vegetales = "Lechuga, pepinillos";
            }
            else if (vegetablesSelec.conLechuga == true && vegetablesSelec.conPepinillos == false && vegetablesSelec.conTomate == true)
            {
                vegetales = "Lechuga, tomate";
            }
            else if (vegetablesSelec.conLechuga == true && vegetablesSelec.conPepinillos == true && vegetablesSelec.conTomate == true)
            {
                vegetales = "Lechuga, pepinillos, tomate";
            }
            else if (vegetablesSelec.conLechuga == false && vegetablesSelec.conPepinillos == true && vegetablesSelec.conTomate == false)
            {
                vegetales = "Pepinillos";
            }
            else if (vegetablesSelec.conLechuga == false && vegetablesSelec.conPepinillos == false && vegetablesSelec.conTomate == true)
            {
                vegetales = "Tomate";
            }
            else if (vegetablesSelec.conLechuga == false && vegetablesSelec.conPepinillos == true && vegetablesSelec.conTomate == true)
            {
                vegetales = "Pepinillos, tomate";
            }
            //Salsas
            if (vegetablesSelec.roja == true && vegetablesSelec.mayo == false && vegetablesSelec.bbq == false)
            {
                salsas = "Roja";
            }
            else if (vegetablesSelec.roja == true && vegetablesSelec.mayo == true && vegetablesSelec.bbq == false)
            {
                salsas = "Roja, mayo";
            }
            else if (vegetablesSelec.roja == true && vegetablesSelec.mayo == false && vegetablesSelec.bbq == true)
            {
                salsas = "Roja, BBQ";
            }
            else if (vegetablesSelec.roja == true && vegetablesSelec.mayo == true && vegetablesSelec.bbq == true)
            {
                salsas = "Roja, mayo, BBQ";
            }
            else if (vegetablesSelec.roja == false && vegetablesSelec.mayo == true && vegetablesSelec.bbq == false)
            {
                salsas = "Mayo";
            }
            else if (vegetablesSelec.roja == false && vegetablesSelec.mayo == false && vegetablesSelec.bbq == true)
            {
                salsas = "BBQ";
            }
            else if (vegetablesSelec.roja == false && vegetablesSelec.mayo == true && vegetablesSelec.bbq == true)
            {
                salsas = "Mayo, BBQ";
            }

        }
        if (productosSelec[1].productoSeleccionado.name == "res")
        {
            n_table.OpenPanelTerminos();
        }
        else
        {
            popupManager.UpdateTexts();
        }
        
    }

    public void PostData() => StartCoroutine(PostData_Coroutine());
 
    IEnumerator PostData_Coroutine()
    {
        
        string uri = "https://634fafae78563c1d82acbefa.mockapi.io/orders";
        WWWForm form = new WWWForm();
        form.AddField("Mesa", SingletonPrecio.instance.numeroMesa);
        form.AddField("Estado", "Pendiente");
        for (int i = 0; i < productosSelec.Length; i++)
        {
            form.AddField(productosSelec[i].categoria, productosSelec[i].productoSeleccionado.name);
        }
        if (terminosData != null && terminosData.termino != "")
        {
            form.AddField("Termino_Carne", terminosData.termino);
        }
        if (vegetablesSelec != null)
        {
            if (vegetablesSelec.conLechuga == true && vegetablesSelec.conPepinillos == false && vegetablesSelec.conTomate == false)
            {
                form.AddField("Vegetales", "Lechuga");
                vegetales = "Lechuga";
            }
            else if (vegetablesSelec.conLechuga == true && vegetablesSelec.conPepinillos == true && vegetablesSelec.conTomate == false)
            {
                form.AddField("Vegetales", "Lechuga, pepinillos");
                vegetales = "Lechuga, pepinillos";
            }
            else if (vegetablesSelec.conLechuga== true && vegetablesSelec.conPepinillos == false && vegetablesSelec.conTomate == true)
            {
                form.AddField("Vegetales", "Lechuga, tomate");
                vegetales = "Lechuga, tomate";
            }
            else if (vegetablesSelec.conLechuga == true && vegetablesSelec.conPepinillos == true && vegetablesSelec.conTomate == true)
            {
                form.AddField("Vegetales", "Lechuga, pepinillos, tomate");
                vegetales = "Lechuga, pepinillos, tomate";
            }
            else if (vegetablesSelec.conLechuga == false && vegetablesSelec.conPepinillos == true && vegetablesSelec.conTomate == false)
            {
                form.AddField("Vegetales", "Pepinillos");
                vegetales = "Pepinillos";
            }
            else if (vegetablesSelec.conLechuga == false && vegetablesSelec.conPepinillos == false && vegetablesSelec.conTomate == true)
            {
                form.AddField("Vegetales", "Tomate");
                vegetales = "Tomate";
            }
            else if (vegetablesSelec.conLechuga == false && vegetablesSelec.conPepinillos == true && vegetablesSelec.conTomate == true)
            {
                form.AddField("Vegetales", "Pepinillos, tomate");
                vegetales = "Pepinillos, tomate";
            }
            //Salsas
            if (vegetablesSelec.roja == true && vegetablesSelec.mayo == false && vegetablesSelec.bbq == false)
            {
                form.AddField("Salsas", "Roja");
                salsas = "Roja";
            }
            else if (vegetablesSelec.roja == true && vegetablesSelec.mayo == true && vegetablesSelec.bbq == false)
            {
                form.AddField("Salsas", "Roja, mayo");
                salsas = "Roja, mayo";
            }
            else if (vegetablesSelec.roja == true && vegetablesSelec.mayo == false && vegetablesSelec.bbq == true)
            {
                form.AddField("Salsas", "Roja, bbq");
                salsas = "Roja, BBQ";
            }
            else if (vegetablesSelec.roja == true && vegetablesSelec.mayo == true && vegetablesSelec.bbq == true)
            {
                form.AddField("Salsas", "Roja, mayo, bbq");
                salsas = "Roja, mayo, BBQ";
            }
            else if (vegetablesSelec.roja == false && vegetablesSelec.mayo == true && vegetablesSelec.bbq == false)
            {
                form.AddField("Salsas", "Mayo");
                salsas = "Mayo";
            }
            else if (vegetablesSelec.roja == false && vegetablesSelec.mayo == false && vegetablesSelec.bbq == true)
            {
                form.AddField("Salsas", "Bbq");
                salsas = "BBQ";
            }
            else if (vegetablesSelec.roja == false && vegetablesSelec.mayo == true && vegetablesSelec.bbq == true)
            {
                form.AddField("Salsas", "Mayo, bbq");
                salsas = "Mayo, BBQ";
            }

        }


        
         
            using (UnityWebRequest request = UnityWebRequest.Post(uri, form))
            {
                yield return request.SendWebRequest();
                if (request.isNetworkError || request.isHttpError)
                {
                    Debug.Log(request.error);//outputArea.text = request.error;
                }
                else
                {
                    Debug.Log(request.downloadHandler.text);//outputArea.text = request.downloadHandler.text;
                    
                }
                
            }
        
    }
}