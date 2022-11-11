using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class PasarDeEscena : MonoBehaviour
{
    public GameObject panelMesas;
    public TMP_InputField inputMesa;
    public void PasarDeEscenada()
    {
        if (inputMesa.text != "")
        {
            SingletonPrecio.instance.numeroMesa = inputMesa.text;
            SceneManager.LoadScene("SelectionScene");
        }
        else
        {
            
            Debug.Log("Debes poner tu número de mesa");
        }
        
    }

    public void BackHome()
    {
        SceneManager.LoadScene(0);
    }
    public void PasarDeEscenaPago()
    {
        SceneManager.LoadScene("Pago");
    }

    public void BackHome2()
    {
        SceneManager.LoadScene(1);
    }

    public void GoToApi()
    {
        SceneManager.LoadScene("testapi");
    }
    public void cuartainterfaz()
    {
        SceneManager.LoadScene("Despuespedido");
    }

    public void showPanelMesas()
    {
        panelMesas.SetActive(true);
    }

}

