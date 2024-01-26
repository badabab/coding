using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test05 : MonoBehaviour
{
    public int w;
    public float h;
    public float h2;

    void Start()
    {
        float h2 = h / 100;
        Debug.Log(string.Format("{0:F2}", w / (h2 * h2)));
    }
}
