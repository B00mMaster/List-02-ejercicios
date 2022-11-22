using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class Exercise2 : MonoBehaviour
{
    public int year ;

    private void Start()
    {
       
        if (year%12 is 1)
        { Debug.Log($"The year {year} belongs to the Rooster"); }
       
        else if (year%12 is 2)
        { Debug.Log($"The year {year} belongs to the Dog"); }
        
        else if (year%12 is 3)
        { Debug.Log($"The year {year} belongs to the Pig"); }

        else if (year%12 is 4)
        { Debug.Log($"The year {year} belongs to the Rat");}
       
        else if(year%12 is 5)
        { Debug.Log($"The year {year} belongs to the Ox"); }
       
        else if (year%12 is 6)
        { Debug.Log($"The year {year} belongs to the Tiger"); }
      
        else if (year%12 is 7)
        { Debug.Log($"The year {year} belongs to the Rabbit"); }
       
        else if (year%12 is 8)
        { Debug.Log($"The year {year} belongs to the Dragon"); }
       
        else if (year%12 is 9)
        { Debug.Log($"The year {year} belongs to the Snake"); }
       
        else if (year%12 is 10)
        { Debug.Log($"The year {year} belongs to the Horse"); }
      
        else if (year%12 is 11)
        { Debug.Log($"The year {year} belongs to the Goat"); }
       
        else if (year%12 is 0)
        { Debug.Log($"The year {year} belongs to the Monkey"); }
      
        



    }
}
