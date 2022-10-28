using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonPrecio: MonoBehaviour
{
    public static SingletonPrecio instance
    { get; private set; }
    public int totalCal, totalGrasas, totalPrecio, precioIva;
    public string numeroMesa;
    public List<string> pedido;
    private void Awake()
    {
        // If there is an instance, and it's not me, delete myself.

        if (instance != null && instance != this)
        {
            DestroyImmediate(gameObject);
        }
        else
        {
            instance = this;
        }
    }

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
}
