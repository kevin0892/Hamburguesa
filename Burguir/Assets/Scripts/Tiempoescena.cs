using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tiempoescena : MonoBehaviour
{
    

    void Start()
    {
        StartCoroutine(Delay());
    }


    IEnumerator Delay()
    {
        yield return new WaitForSecondsRealtime(4);
        cambiar();
    }
    // Update is called once per frame
    void cambiar()
    {
        SceneManager.LoadScene("inicio");
    }
}
