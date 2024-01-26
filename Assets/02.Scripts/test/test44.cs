using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test44 : MonoBehaviour
{
    public string Word = "level";

    void Start()
    {
        bool[] check = new bool[Word.Length / 2];
        
        for (int i = 0; i < Word.Length / 2; i++)
        {   
            if (Word[i] == Word[Word.Length -1 - i])
            {
                check[i] = true;
            }
        }

        bool result = true;

        for (int i = 0;i < check.Length; i++)
        {
            if (check[i] == false)
            {
                result = false;
            }
        }

        if (result == true)
        {
            Debug.Log(1);
        }
        else if (result == false)
        {
            Debug.Log(0);
        }
    }
}
