using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using TMPro;
 
public class PostMethod : MonoBehaviour
{
    // public TMP_InputField outputArea;
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