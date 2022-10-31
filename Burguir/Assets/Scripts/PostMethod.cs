using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using TMPro;
 
public class PostMethod : MonoBehaviour
{
    // public TMP_InputField outputArea;
    public Vegetables vegetablesSelec;
    public Selection[] productosSelec;
    public string pan_up, carne, pan_down;
 
    void Start()
    {
        Debug.Log("hola");
        //outputArea = GameObject.Find("OutputArea").GetComponent<TMP_InputField>();
        GameObject.Find("Pedir").GetComponent<Button>().onClick.AddListener(PostData);
    }

    private void Update()
    {
        //print("hola" + SingletonPrecio.instance.totalPrecio);
    }

    public void PostData() => StartCoroutine(PostData_Coroutine());
 
    IEnumerator PostData_Coroutine()
    {
        
        string precio = "2340";//SingletonPrecio.instance.totalPrecio.ToString();
        //outputArea.text = "Loading...";
        string uri = "https://634fafae78563c1d82acbefa.mockapi.io/orders";
        WWWForm form = new WWWForm();
        form.AddField("Mesa", SingletonPrecio.instance.numeroMesa);
        form.AddField("Estado", "Pendiente");
        for (int i = 0; i < productosSelec.Length; i++)
        {
            form.AddField(productosSelec[i].categoria, productosSelec[i].productoSeleccionado.name);
        }
        if (vegetablesSelec != null)
        {
            if (vegetablesSelec.conLechuga == true && vegetablesSelec.conPepinillos == false && vegetablesSelec.conTomate == false)
            {
                form.AddField("Vegetales", "Lechuga");
            }
            else if (vegetablesSelec.conLechuga == true && vegetablesSelec.conPepinillos == true && vegetablesSelec.conTomate == false)
            {
                form.AddField("Vegetales", "Lechuga, pepinillos");
            }
            else if (vegetablesSelec.conLechuga== true && vegetablesSelec.conPepinillos == false && vegetablesSelec.conTomate == true)
            {
                form.AddField("Vegetales", "Lechuga, tomate");
            }
            else if (vegetablesSelec.conLechuga == true && vegetablesSelec.conPepinillos == true && vegetablesSelec.conTomate == true)
            {
                form.AddField("Vegetales", "Lechuga, pepinillos, tomate");
            }
            else if (vegetablesSelec.conLechuga == false && vegetablesSelec.conPepinillos == true && vegetablesSelec.conTomate == false)
            {
                form.AddField("Vegetales", "Pepinillos");
            }
            else if (vegetablesSelec.conLechuga == false && vegetablesSelec.conPepinillos == false && vegetablesSelec.conTomate == true)
            {
                form.AddField("Vegetales", "Tomate");
            }
            else if (vegetablesSelec.conLechuga == false && vegetablesSelec.conPepinillos == true && vegetablesSelec.conTomate == true)
            {
                form.AddField("Vegetales", "Pepinillos, tomate");
            }
            //Salsas
            if (vegetablesSelec.roja == true && vegetablesSelec.mayo == false && vegetablesSelec.bbq == false)
            {
                form.AddField("Salsas", "Roja");
            }
            else if (vegetablesSelec.roja == true && vegetablesSelec.mayo == true && vegetablesSelec.bbq == false)
            {
                form.AddField("Salsas", "Roja, mayo");
            }
            else if (vegetablesSelec.roja == true && vegetablesSelec.mayo == false && vegetablesSelec.bbq == true)
            {
                form.AddField("Salsas", "Roja, bbq");
            }
            else if (vegetablesSelec.roja == true && vegetablesSelec.mayo == true && vegetablesSelec.bbq == true)
            {
                form.AddField("Salsas", "Roja, mayo, bbq");
            }
            else if (vegetablesSelec.roja == false && vegetablesSelec.mayo == true && vegetablesSelec.bbq == false)
            {
                form.AddField("Salsas", "Mayo");
            }
            else if (vegetablesSelec.roja == false && vegetablesSelec.mayo == false && vegetablesSelec.bbq == true)
            {
                form.AddField("Salsas", "Bbq");
            }
            else if (vegetablesSelec.roja == false && vegetablesSelec.mayo == true && vegetablesSelec.bbq == true)
            {
                form.AddField("Salsas", "Mayo, bbq");
            }

        }
        
        form.AddField("Precio", precio);
        
        using (UnityWebRequest request = UnityWebRequest.Post(uri, form))
        {
            yield return request.SendWebRequest();
            if (request.isNetworkError || request.isHttpError)
                Debug.Log(request.error);//outputArea.text = request.error;
            else
                Debug.Log(request.downloadHandler.text);//outputArea.text = request.downloadHandler.text;
        }
    }
}