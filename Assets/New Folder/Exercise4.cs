using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise4 : MonoBehaviour
{
   public float Base=00;

    public float heigh = 00;

    
    private void Start()
    {
        if( Base * heigh / 2 > 0)
        { Debug.Log($"The area of the triangle with base {Base} and height {heigh} is {Base * heigh / 2}"); }

        else { Debug.Log("The area cannot be calculated"); }







    }






















}
