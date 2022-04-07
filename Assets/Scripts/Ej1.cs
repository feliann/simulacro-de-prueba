using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//1.Crea un programa que pida dos números al usuario y responda si son iguales o no lo son.

public class Ej1 : MonoBehaviour
{

    // Start is called before the first frame update
    public int num1;
    public int num2;
    void Start()
    {
        if (num1== num2)
        {
            Debug.Log("Los dos numeros son iguales");
        }
        else
        {
            Debug.Log("los numeros son diferentes");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
