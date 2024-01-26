using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test14 : MonoBehaviour
{
    public int N;
    // 1 <= N <= 10000

    void Start()
    {
        int i;
        int sum = 0;
        for (i = 0; i <= N; i++)
        {
            sum += i;
        }
        Debug.Log(sum);
    }
}
