using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplesOfThreeTwo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ShowMultiplesOfThree();
        ShowMultiplesOfTwo();
    }

    // Inicializamos el metodo
    void ShowMultiplesOfThree()
    {
        // Muestra en consola mensaje para los multiplos de 3
        Debug.Log("Multiplos de 3: ");
        // Iniciamos bucle para multiplos de 3
        for (int i = 0; i <= 100; i += 3)
        {
            //Mostramos en consola el bucle
            Debug.Log(i);

        }
    }

    // Inicializamos el segundo metodo
    void ShowMultiplesOfTwo()
    {
        //Muestra en consola mensaje para los multiplos de 2
        Debug.Log("Multiplos de 2: ");
        // Iniciamos bucle para multiplos de 2
        for (int i = 0; i <= 100; i += 2)
        {
            // Mostramos en consola el resultado
            Debug.Log(i);
        }
    }
}