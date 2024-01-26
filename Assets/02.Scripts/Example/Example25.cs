using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example25 : MonoBehaviour
{
    public int[] N;

    void Start()
    {
        Debug.Log(N.Length);

        int count = N.Length;

        for (int i = 0; i < count; i++)
        {
            Debug.Log(N[i]);
        }

    }
}
