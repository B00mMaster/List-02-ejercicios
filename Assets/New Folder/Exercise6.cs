using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise6 : MonoBehaviour
{
    public float distanceTraveled = 00;

    public float distanceTotal = 00;


    private void Start()
    {
        if (distanceTraveled >= distanceTotal)

        {
            Debug.Log("Congratulations! You have completed the total distance");
                
        }

        else { Debug.Log($"Oh… You still have {distanceTotal - distanceTraveled}meters left to complete the total distance"); }

    }



}
