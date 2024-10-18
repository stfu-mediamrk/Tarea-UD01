using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FromSmallestToLargest : MonoBehaviour
{
    //Variables globales
    public int number1;
    public int number2;
    public int number3;

    // Start is called before the first frame update
    void Start()
    {
        //Muestra en la consola los numeros elegidos
        Debug.Log("Los numeros introducidos son: " + number1 + ", " + number2 + ", " + number3);

        //Variable para el orden de los numeros
        int smallest, middle, largest;

        //Variable que ordena los numeros con operadores de comparacion
        if (number1 <= number2 && number1 <= number3)
        {
            smallest = number1;
            if (number2 <= number3)
            {
                middle = number2;
                largest = number3;
            }
            else
            {

                middle = number3;
                largest = number2;

            }
        }
        
        else if (number2 <= number1 && number2 <= number3)
        {
            smallest = number2;
            if (number1 <= number3)
            {
                middle = number1;
                largest = number3;
            }
            else
            {
                middle = number3;
                largest = number1;
            }
        }
        else
        {
            smallest = number3;
            if (number1 <= number2)
            {
                middle = number1;
                largest = number2;
            }
            else
            {
                middle = number2;
                largest = number1;
            }
        }

        //Mensaje final con el orden
        Debug.Log("Los numeros de mayor a menos son: " + smallest + ", " + middle + " y " + largest );
    }


}
