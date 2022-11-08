using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vegetables : MonoBehaviour
{
    public Toggle[] toggles;
    public Toggle[] salsasToggles;
    public GameObject pepinillos, tomates, lechuga;
    public bool conPepinillos= false, conTomate = false, conLechuga = false;
    public bool roja = false, mayo = false, bbq = false;
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

        for (int i = 0; i < salsasToggles.Length; i++)
        {
            salsasToggles[i].isOn = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (toggles[0].isOn == true)
        {
            pepinillos.SetActive(true);
            conPepinillos = true;
        }
        else
        {
            pepinillos.SetActive(false);
            conPepinillos = false;
        }
        if(toggles[1].isOn == true)
        {
            tomates.SetActive(true);
            conTomate = true;
        }
        else
        {
            tomates.SetActive(false);
            conTomate = false;
        }
        if (toggles[2].isOn == true)
        {
            lechuga.SetActive(true);
            conLechuga = true;
        }
        else
        {
            lechuga.SetActive(false);
            conLechuga = false;
        }

        if (salsasToggles[0].isOn == true)
        {
            roja = true;
        }
        else
        {
            roja = false;
        }
        if(salsasToggles[1].isOn == true)
        {
            mayo = true;
        }
        else
        {
            mayo = false;
        }
        if(salsasToggles[2].isOn == true)
        {
            bbq = true;
        }
        else
        {
            bbq = false;
        }
    }
}
