using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using TMPro;
 
public class PostMethod : MonoBehaviour
{
    public TMP_InputField outputArea;
 
    void Start()
    {
        outputArea = GameObject.Find("OutputArea").GetComponent<TMP_InputField>();
        //GameObject.Find("PostButton").GetComponent<Button>().onClick.AddListener(PostData);
    }

    private void Update()
    {
        //print("hola" + SingletonPrecio.instance.totalPrecio);
    }

    public void PostData() => StartCoroutine(PostData_Coroutine());
 
    IEnumerator PostData_Coroutine()
    {
        string precio = "2340";//SingletonPrecio.instance.totalPrecio.ToString();
        outputArea.text = "Loading...";
        string uri = "https://634fafae78563c1d82acbefa.mockapi.io/orders_list";
        WWWForm form = new WWWForm();
        form.AddField("title", "Test 2");
        form.AddField("Mesa", "004");
        form.AddField("Pedido", "Pan blanco, Res 3/4, Tomates, Pan blanco");
        form.AddField("Precio", precio);
        using (UnityWebRequest request = UnityWebRequest.Post(uri, form))
        {
            yield return request.SendWebRequest();
            if (request.isNetworkError || request.isHttpError)
                outputArea.text = request.error;
            else
                outputArea.text = request.downloadHandler.text;
        }
    }
}