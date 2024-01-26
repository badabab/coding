using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test21 : MonoBehaviour
{
    public int N;

    void Start()
    {
        string line = "";
        for (int i = 1; i <= N; i++)
        {
            line = "";
            for (int k = N - i; k > 0; k--)
            {
                line += "  ";
            }

            for (int j = 1; j <= i; j++)
            {
                line += "*";
            }
            Debug.Log(line);
        }

        for (int i = 1; i <= N - 1; i++)
        {
            line = "";
            for (int j = 1; j <= i; j++)
            {
                line += "  ";
            }

            for (int k = N - i; k > 0; k--)
            {
                line += "*";
            }

            Debug.Log(line);
        }
    }
}
