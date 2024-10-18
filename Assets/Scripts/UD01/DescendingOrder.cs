using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescendingOrder : MonoBehaviour
{
    // Variables globales
    public float number1;
    public float number2;
    public float number3;

    // Start is called before the first frame update
    void Start()
    {
        //Llamamos al metodo
        CheckIncreasingOrder(number1, number2, number3);
    }

    void CheckIncreasingOrder(float number1, float number2, float number3)
    {
        if (number1 > number2 && number2 > number3)
        {
            Debug.Log("Los numeros estan en orden decreciente.");
        }
        else
        {
            Debug.Log("Los numeros no estan en orden decreciente");
        }
    }

}
