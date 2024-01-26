using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test07 : MonoBehaviour
{
    public int A, B, C;
    public int max, min;

    void Start()
    {
        if (A < B)
        {
            min = A;
            max = B;
        }
        else
        {
            min = B;
            max = A;
        }
        if (C < min)
        {
            Debug.Log($"{C} {min} {max}");
        }
        else if (C > max)
        {
            Debug.Log($"{min} {max} {C}");
        }
        else
        {
            Debug.Log($"{min} {C} {max}");
        }
    }
}
