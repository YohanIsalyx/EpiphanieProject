using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstInterruptor : MonoBehaviour
{
    public Material On;
    public Material Off;

    private Color defaultColor;

    private void Start()
    {
        defaultColor = GetComponent<MeshRenderer>().material.color;
    }

    private void OnTriggerEnter(Collider other)
    {
        // SIMILAIRE
        //GetComponent<MeshRenderer>().material = On;
        GetComponent<MeshRenderer>().material.color = Color.green;
    }

    private void OnTriggerExit(Collider other)
    {       
        // SIMILAIRE
        //GetComponent<MeshRenderer>().material = Off;
        GetComponent<MeshRenderer>().material.color = defaultColor;
    }
}
