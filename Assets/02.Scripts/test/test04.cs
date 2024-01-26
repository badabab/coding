using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test04 : MonoBehaviour
{
    public int A;
    public int B;

    public int C, D, E;

    void Start()
    {
        C = (B % 10)%10;
        D = (B / 10)%10;
        E = B / 100;

        Debug.Log(A * C);
        Debug.Log(A * D);
        Debug.Log(A * E);

        Debug.Log(A * B);
        
    }
}
