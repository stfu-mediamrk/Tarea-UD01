using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Odd : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ShowOddNumbers();

    }

    // Inicializamos el metodo
    void ShowOddNumbers()
    {
        // Iniciamos bucle para numeros impares
        for (int i = 1; i <= 100; i += 2)
        {
            //Mostramos en consola el bucle
            Debug.Log(i);

        }
    }
}
