using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Selection : MonoBehaviour
{
    Vector3 targetRot;
    Vector3 currentAngle;
    Vector3 posIni;
    public float horizontalPos;
    public int currentSelection;
    int totalCharacters = 4;
    bool toggle = false;
    public Producto[] productos;
    public Producto productoSeleccionado;

    //UI-Navigation Items
    public TMP_Text notificationText;

    void Start()
    {
        currentSelection = 1;
        productoSeleccionado = productos[currentSelection-1];
    }

    void Update()
    {

        /*if (Input.GetMouseButtonDown(0))
        {
            posIni = Input.mousePosition;
        }
        if (Input.GetMouseButtonUp(0))
        {
            if ((posIni - Input.mousePosition).magnitude > 150)
            {
                horizontalPos = (posIni - Input.mousePosition).x;
                if (horizontalPos < 0)
                {
                    Anterior();
                }
                else
                {
                    Siguiente();
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Siguiente();
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Anterior();
        }*/
        currentAngle = new Vector3(0, Mathf.LerpAngle(currentAngle.y, targetRot.y, 2.0f * Time.deltaTime));
        transform.eulerAngles = currentAngle;

    }

    public void Siguiente()
    {
        if (currentSelection < totalCharacters)
        {
            currentAngle = transform.eulerAngles;
            targetRot = targetRot + new Vector3(0, 90, 0);
            currentSelection++;
            //_audio._audioSource.PlayOneShot(_audio.jumping);
        }
        else if(currentSelection == totalCharacters)
        {
            currentAngle = transform.eulerAngles;
            targetRot = targetRot + new Vector3(0, 90, 0);
            currentSelection = 1;
        }
        productoSeleccionado = productos[currentSelection-1];
    }

    public void Anterior()
    {
        if (currentSelection > 1)
        {
            currentAngle = transform.eulerAngles;
            targetRot = targetRot - new Vector3(0, 90, 0);
            currentSelection--;
            //_audio._audioSource.PlayOneShot(_audio.sliding);
        }
        else if(currentSelection == 1)
        {
            currentAngle = transform.eulerAngles;
            targetRot = targetRot - new Vector3(0, 90, 0);
            currentSelection = totalCharacters;
        }
    }




}

[System.Serializable]
public class Producto
{
    public int calorias, grasas, precio;
}
