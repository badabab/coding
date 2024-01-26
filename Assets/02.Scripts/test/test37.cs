using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test37 : MonoBehaviour
{
    public string Input = "Hello C#";

    void Start()
    {
        string output = "";
        for (int i = Input.Length -1; i >= 0; i--)
        {
            output += Input[i];
        }
        Debug.Log(output);
    }

}
