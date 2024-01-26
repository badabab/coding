using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test40 : MonoBehaviour
{
    void Start()
    {
        /* 
        // 입력 코드1
        char[][] inputArray = new char[][]
        {
            new char[] { 'A', 'B', 'C', 'D', 'E' },
            new char[] { 'a', 'b', 'c', 'd', 'e' },
            new char[] { '0', '1', '2', '3', '4' },
            new char[] { 'F', 'G', 'H', 'I', 'J' },
            new char[] { 'f', 'g', 'h', 'i', 'j' }
        };
        */

        // 입력 코드2
        char[][] inputArray = new char[][]
        {
            new char[] { 'A', 'A', 'B', 'C', 'D', 'D' },
            new char[] { 'a', 'f', 'z', 'z' },
            new char[] { '0', '9', '1', '2', '1' },
            new char[] { 'a', '8', 'E', 'W', 'g', '6' },
            new char[] { 'P', '5', 'h', '3', 'k', 'x' }
        };
        
        string output = "";
        /*
        for (int i = 0; i < inputArray.Length; i++)
        {
            for (int j = 0; j < inputArray[i].Length; j++)
            {
                output += inputArray[i][j];
                // Debug.Log(inputArray[i][j]);
            }
        }
        */

        for (int i = 0; i < inputArray.Length; i++)
        {
            output += new string(inputArray[i]);
        }
        Debug.Log(output);
    }
}
