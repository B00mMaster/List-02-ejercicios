using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise1 : MonoBehaviour
{
    public float num = 00;

    private void Start() 
    {
        if (num is 0)
        {
            Debug.Log($"The number is {num} ");
        }

        else if  (num < 0)
        {
            Debug.Log($"{num} is negative");
        }
         else  
            {
                Debug.Log($"{num} is positive");
            }
    }
}
