using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test19 : MonoBehaviour
{
    /**
    public int N;

    void Start()
    {
        for (int i = 1; i<= N; i++)
        {
            string line = "";
            for (int j = 1; j <= i; j++)
            {
                line += "*";
            }
            Debug.Log(line);
        }
    }
    **/

    public int N = 5;

    void Start()
    {
        for (int i =1; i <= N; i++)
        {
            string star = "";
            
            for (int j = 0; j <= i; j++)
            {
                star += "*";
            }

            Debug.Log(star);
        }
    }
}
