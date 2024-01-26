using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class test20 : MonoBehaviour
{
    public int N;

    void Start()
    {
        for (int i = 1; i <= N; i++)
        {
            string line = "";
            for (int k = N - (i-1); k > 0; k--)
            {
                line += "  ";
            }

            for (int j = 1; j <= i; j++)
            {
                line += "*";
            }
            

            Debug.Log(line);
        }
    }
}
