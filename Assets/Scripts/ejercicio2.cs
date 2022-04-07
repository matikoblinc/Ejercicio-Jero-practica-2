using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio2 : MonoBehaviour
{
    public int num1;
    public int num2;
    public int num3;
    public int DineroDisponible;
    int num4;
    int num5;

    void Start()
    {
        num4 = num1 + num2 + num3;

        if (num4 > DineroDisponible)
        {
            num5 = num4 - DineroDisponible;
            Debug.Log("La cantidad de dinero necesaria es mayor a la disponible por: $" + num5);
        }

        else if (num4 == DineroDisponible)
        {
            Debug.Log("La cantidad de dinero es justo lo que tenes");
        }

        else
        {
            num5 = DineroDisponible - num4;
            Debug.Log("La cantidad de dinero necesaria es menor a la disponible por: $" + num5);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

//2.Crear las variables necesarias para ingresar por Inspector el precio de 3 productos y un monto de dinero disponible. 
//Comunicar si la suma de los mismos supera o no el monto de dinero disponible. Luego indicar cuánto dinero sobra o falta.
