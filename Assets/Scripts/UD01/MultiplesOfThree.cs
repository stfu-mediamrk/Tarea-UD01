using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplesOfThree : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ShowMultiplesOfThree();

    }

    // Inicializamos el metodo
    void ShowMultiplesOfThree()
    {
        // Iniciamos bucle para multiplos de 3
        for (int i = 0; i <= 100; i += 3)
        {
            //Mostramos en consola el bucle
            Debug.Log(i);

        }
    }
}
