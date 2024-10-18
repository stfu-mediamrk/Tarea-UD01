using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Even : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ShowEvenNumbers();

    }

    // Inicializamos el metodo
    void ShowEvenNumbers()
    {
        // Iniciamos bucle para numeros pares
        for (int i = 0; i <= 100; i += 2)
        {
            //Mostramos en consola el bucle
            Debug.Log(i);

        }
    }
}