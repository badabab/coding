using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test17 : MonoBehaviour
{
    public int N;
    
    void Start()
    {
        for (int i = 1; i < 10; i++)
        {
            Debug.Log($"{N} * {i} = {N*i}");
        }
    }
}
