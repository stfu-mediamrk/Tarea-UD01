using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Month : MonoBehaviour
{
    //Variables globales 
    public int monthNumber = 1; // Este valor se cambia para los diferentes meses, el usuario introduce el numero aqui

    // Start is called before the first frame update
    void Start()
    {
        //Muestra el texto con el nombre del mes
        Debug.Log("El mes que corresponde a su número es: " + GetMonthName(monthNumber));
    }

    
    string GetMonthName(int monthNumber){

        //Esta funcion recibe el numero y devuelve el nombre del mes correspondiente
        switch (monthNumber){
            
            case 1: return "Enero";
            case 2: return "Febrero";
            case 3: return "Marzo";
            case 4: return "Abril";
            case 5: return "Mayo";
            case 6: return "Junio";
            case 7: return "Julio";
            case 8: return "Agosto";
            case 9: return "Septiembre";
            case 10: return "Octubre";
            case 11: return "Noviembre";
            case 12: return "Noviembre";
            default: return "Número no válido";
        }
    }
}
