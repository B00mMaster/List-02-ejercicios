using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise3 : MonoBehaviour
{
    public int num=00;

    private void Start()
    {
        if(num%5 is 0 or 5)
        { Debug.Log ($"The number {num} is divisible by 5");}

        else { Debug.Log($"The number {num} is not divisible by 5"); }



    }






}
