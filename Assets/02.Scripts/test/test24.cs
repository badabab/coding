using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test24 : MonoBehaviour
{
    public int[] A = { 1, 10, 4, 9, 2, 3, 8, 5, 7, 6 };
    public int B = 5;
    
    void Start()
    {
        string result = "";
        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] < B)
            {
                result += (A[i] + " ");
            }
        }
        Debug.Log(result);
    }
}
