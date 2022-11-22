using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise10 : MonoBehaviour
{
    public int year;

    private void Start()
    {

        if (0 ==year%4)
        { 
            if(0==year%100)
            { 
                if(0==year%400)
                {
                 Debug.Log($"{year} is a leap year");
                }
                else
                {
                    Debug.Log($"{year} is not a leap year");
                }
            }
            else
            {
                Debug.Log($"{year} is a leap year");
            }
        }
        else 
        {
        Debug.Log($"{year} is not a leap year");
        }
    }
}
