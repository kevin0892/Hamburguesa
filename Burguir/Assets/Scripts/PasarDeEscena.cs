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
}

