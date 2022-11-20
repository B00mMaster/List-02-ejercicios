using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise7 : MonoBehaviour
{
    public string operation="";
    public float x;
    public float y;

    private void Start()
    {
        if (operation is "sum")
        { Debug.Log($"{x}+{y}={x+y}"); }

        else if (operation is "rest")
        { Debug.Log($"{x}-{y}={x-y}"); }

        else if (operation is "product")
        { Debug.Log($"{x}x{y}={x*y}"); }

        else if (operation is "division")
        { Debug.Log($"{x}/{y}={x/y}"); }

    }

















}
