using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise10 : MonoBehaviour
{
    public int year;

    private void Start()
    {
       if ( year%4 is 0 or 4  or 16 or 8 )

            {
            Debug.Log($"The year {year} is a leap year");
                
            }
       else
        {
            Debug.Log($"The year {year} is not a leap year");
        }

    }






















}
