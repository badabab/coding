using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test34 : MonoBehaviour
{
    public string Input = "A";

    void Start()
    {
        char asc_c = Input[0];
        int asc_i = (int)asc_c;
        Debug.Log(asc_i);
    }

}
