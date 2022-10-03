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
        print("hola" + SingletonPrecio.instance.totalPrecio);
    }

    public void PostData() => StartCoroutine(PostData_Coroutine());
 
    IEnumerator PostData_Coroutine()
    {
        string precio = SingletonPrecio.instance.totalPrecio.ToString();
        outputArea.text = "Loading...";
        string uri = "https://6327fad49a053ff9aaadb7e8.mockapi.io/Pedido";
        WWWForm form = new WWWForm();
        form.AddField("title", "test data");
        form.AddField("Mesa", "003");
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