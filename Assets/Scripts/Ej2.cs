using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej2 : MonoBehaviour

    //2.Solicitar el ingreso del precio de 3 productos y un monto de dinero disponible
    //.Comunicar si la suma de los mismos supera o no el monto de dinero disponible.
    //Luego indicar cuánto dinero sobra o falta.
{
    // Start is called before the first frame update
    public float precio1;
    public float precio2;
    public float precio3;
    public float monto;
    void Start()
    {
            if (precio1+precio2+precio3<monto)
        {
            Debug.Log("Podes comprar los tres productos con la plata que tenes");
        }
            else
        {
            Debug.Log("No tenes suficientes plata para comprar los tres productos");
        }
        if (precio1 + precio2 + precio3 < monto)
        {
            float res1;
            res1 = monto - (precio1 + precio2 + precio3);
            Debug.Log("te sobra" + res1);
        }
        else if (precio1 + precio2 + precio3 > monto)
        {
            float res2;
            res2 = (precio1 + precio2 + precio3)-monto;
            Debug.Log("te sobra" + res2);
        }
    }

   
}
