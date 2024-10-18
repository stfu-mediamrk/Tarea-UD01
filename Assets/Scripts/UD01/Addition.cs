using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addition : MonoBehaviour
{
    // Variables globales
    // No ponemos publica la variable "sum" porque no necesitamos modificarla desde el inspector
    public int number;

    // Start is called before the first frame update
    void Start()
    {
        // Llamamos al metodo
        int sum = SumNumbers(number);
        Debug.Log("La suma de los numeros del 1 al " + number + " es: " + sum);
    }

    // Iniciamos bucle
    int SumNumbers(int n)
    {
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }
        return sum;
    }
}
