using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PasarDeEscena : MonoBehaviour
{

    public void PasarDeEscenada()
    {
        SceneManager.LoadScene("SelectionScene");
    }

    public void BackHome()
    {
        SceneManager.LoadScene(0);
    }
        public void PasarDeEscenada2()
    {
        SceneManager.LoadScene("Pago");
    }

    public void BackHome2()
    {
        SceneManager.LoadScene(1);
    }


}

