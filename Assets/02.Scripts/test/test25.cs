using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test25 : MonoBehaviour
{
    public int[] A = { 20, 10, 35, 30, 7 };

    void Start()
    {
        int min = A[0];
        int max = A[0];

        for (int i = 1; i < A.Length; i++)
        {
            if (min < A[i])
            {
                continue;
            }
            min = A[i];
        }
        for (int i = 1;i < A.Length; i++)
        {
            if (max > A[i])
            {
                continue;
            }
            max = A[i];
        }
        Debug.Log($"{min} {max}");
    }
}
