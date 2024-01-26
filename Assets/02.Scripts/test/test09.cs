using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test09 : MonoBehaviour
{
    public int year;

    void Start()
    {
        if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
        {
            Debug.Log("1");
        }
        else
        {
            Debug.Log("0");
        }        
    }
}
