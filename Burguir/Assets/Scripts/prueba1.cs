using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class prueba1 : MonoBehaviour
{
    public Text scoreText;

    int _Score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = _Score.ToString() + " Valor ";
    }

    public void AddPoint(int valor)
    {
        _Score += valor;
        scoreText.text = _Score.ToString() + "Value";


    }
}
