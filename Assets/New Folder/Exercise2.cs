using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class Exercise2 : MonoBehaviour
{
    public int year=0 ;

    private void Start()
    {
        if (year is 2017)
        { Debug.Log($"The year {year} belongs to the Rooster"); }
       
        else if (year is 2018)
        { Debug.Log($"The year {year} belongs to the Dog"); }
        
        else if (year is 2019)
        { Debug.Log($"The year {year} belongs to the Pig"); }

        else if (year is 2020)
        { Debug.Log($"The year {year} belongs to the Rat");}
       
        else if(year is 2021)
        { Debug.Log($"The year {year} belongs to the Ox"); }
       
        else if (year is 2022)
        { Debug.Log($"The year {year} belongs to the Tiger"); }
      
        else if (year is 2023)
        { Debug.Log($"The year {year} belongs to the Rabbit"); }
       
        else if (year is 2024)
        { Debug.Log($"The year {year} belongs to the Dragon"); }
       
        else if (year is 2025)
        { Debug.Log($"The year {year} belongs to the Snake"); }
       
        else if (year is 2026)
        { Debug.Log($"The year {year} belongs to the Horse"); }
      
        else if (year is 2027)
        { Debug.Log($"The year {year} belongs to the Goat"); }
       
        else if (year is 2028)
        { Debug.Log($"The year {year} belongs to the Monkey"); }
      
        



    }
}
