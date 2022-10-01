using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vegetables : MonoBehaviour
{
    public Toggle[] toggles;
    public GameObject pepinillos, tomates, lechuga;
    // Start is called before the first frame update
    void Start()
    {
        pepinillos.SetActive(false);
        tomates.SetActive(false); 
        lechuga.SetActive(false);
        for (int i = 0; i < toggles.Length; i++)
        {
            toggles[i].isOn = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (toggles[0].isOn == true)
        {
            pepinillos.SetActive(true);
        }
        else
        {
            pepinillos.SetActive(false);
        }
        if(toggles[1].isOn == true)
        {
            tomates.SetActive(true);
        }
        else
        {
            tomates.SetActive(false);
        }
        if (toggles[2].isOn == true)
        {
            lechuga.SetActive(true);
        }
        else
        {
            lechuga.SetActive(false);
        }
    }
}
