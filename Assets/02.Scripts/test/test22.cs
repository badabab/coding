using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test22 : MonoBehaviour
{
    public int N;
    void Start()
    {
        for (int i = 1; i <= N; i++)
        {
            string line = "";
            for (int j = 1; j <= i; j++)
            {
                line += "*";
            }
            Debug.Log(line);
        }
        for (int i = N-1; i > 0; i--)
        {
            string line = "";
            for (int j = 1; j <= i; j++)
            {
                line += "*";
            }
            Debug.Log(line);
        }

    }
}
