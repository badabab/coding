using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class test15 : MonoBehaviour
{
    public int N;
    // 1 <= N <= 10000

    void Start()
    {
        int sum = 0;

        for (int i = 0; i <= N; i++)
        {
            int j = i % 3;
            if (j == 0)
            {
                continue;
            }
            sum += i;
        }
        Debug.Log(sum);
    }
}
