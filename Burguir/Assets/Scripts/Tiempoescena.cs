using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tiempoescena : MonoBehaviour
{
    public float tiempo = 10;

    void Start()
    {
        Invoke("cambiar", tiempo);
    }

    // Update is called once per frame
    void cambiar()
    {
        SceneManager.LoadScene("inicio");
    }
}
