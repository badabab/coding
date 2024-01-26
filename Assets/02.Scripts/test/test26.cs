using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test26 : MonoBehaviour
{
    public int[] A = { 20, 10, 35, 30, 7 };

    void Start()
    {
        float sum = 0;
        float average = 0;
        for (int i = 0; i < A.Length; i++)
        {
            sum += A[i];
        }
        //Debug.Log(sum);
        average = sum / A.Length;
        Debug.Log(average);
    }
}
