using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImagenCarnes : MonoBehaviour
{
    public Image imagencarne;
    // Start is called before the first frame update
    public Sprite[] imagenes;
    void Start()
    {
        imagencarne.sprite = imagenes[PlayerPrefs.GetInt("Carne", 0)];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
