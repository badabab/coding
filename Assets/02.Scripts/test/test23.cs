using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test23 : MonoBehaviour
{
    public int[] N = { 1, 4, 1, 2, 4, 2, 4, 2, 3, 4, 4 };
    public int v = 2;

    void Start()
    {
        int count = 0;
        for (int i = 0; i < N.Length; i++)
        {
            if (N[i] == v)
            {
                count += 1;
            }
        }
        Debug.Log(count);
    }
}
