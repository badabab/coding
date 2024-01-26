using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test18 : MonoBehaviour
{  
    void Start()
    {
        for (int n = 2; n < 10; n++)
        {
            for (int i = 1; i < 10; i++)
            {
                Debug.Log($"{n} * {i} = {n * i}");
            }
            Debug.Log("----------");
        }
    }
}
