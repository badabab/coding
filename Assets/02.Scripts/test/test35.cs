using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test35 : MonoBehaviour
{
    public string Input = "ACDKJFOWIEGHE";
    public string Input2 = "0";
    public string Input3 = "AB";

    void Start()
    {
        Debug.Log($"{Input[0]}{Input[Input.Length - 1]}");  
        Debug.Log($"{Input2[0]}{Input2[Input2.Length - 1]}");  
        Debug.Log($"{Input3[0]}{Input3[Input3.Length - 1]}");  
    }   
}
