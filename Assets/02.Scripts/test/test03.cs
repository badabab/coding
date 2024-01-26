using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test03 : MonoBehaviour
{
    public int A;
    public int B;
    public int C;

    void Start()
    {
        Debug.Log((A + B) % C);
        Debug.Log((A % C) % C);
        Debug.Log((A * B) % C);
        Debug.Log((B % C) % C);
    }
}
