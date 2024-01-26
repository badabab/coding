using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test06 : MonoBehaviour
{
    public int A, B;

    void Start()
    {
        if (A > B)
        {
            Debug.Log(">");
        }
        else if (A < B)
        {
            Debug.Log("<");
        }
        else // A==B
        {
            Debug.Log("==");
        }
    }
}
