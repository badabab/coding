using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test16 : MonoBehaviour
{
    public int N;
    // 0 <= N <= 12

    void Start()
    {
        int i;
        int sum = 1;
        for (i = 1; i <= N; i++)
        {
            sum = sum * i;
        }
        Debug.Log(sum);
    }
}
