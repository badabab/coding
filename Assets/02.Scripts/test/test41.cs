using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test41 : MonoBehaviour
{
    void Start()
    {
        /*
        // 입력 코드
        char[][] inputArray = new char[][]
        {
            new char[] { 'A', 'B', 'C', 'D', 'E' },
            new char[] { 'a', 'b', 'c', 'd', 'e' },
            new char[] { '0', '1', '2', '3', '4' },
            new char[] { 'F', 'G', 'H', 'I', 'J' },
            new char[] { 'f', 'g', 'h', 'i', 'j' }
        };
        */
        
        // 입력 코드
        char[][] inputArray = new char[][]
        {
            new char[] { 'A', 'A', 'B', 'C', 'D', 'D' },
            new char[] { 'a', 'f', 'z', 'z' },
            new char[] { '0', '9', '1', '2', '1' },
            new char[] { 'a', '8', 'E', 'W', 'g', '6' },
            new char[] { 'P', '5', 'h', '3', 'k', 'x' }
        };

        // Debug.Log(inputArray.Length); // 5
        // 행(가로) row    열(세로) col

        // 가장 긴 열의 길이
        int maxCol = 0;
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length > maxCol)
            {
                maxCol = inputArray[i].Length;
            }
        }
        // 출력
        string output = string.Empty;
        for (int col = 0; col < maxCol; col++)
        {
            for (int row = 0; row < inputArray.Length; row++)
            {
                if (col < inputArray[row].Length)
                {
                    output += inputArray[row][col];
                }
            }
        }
        Debug.Log(output);
    }
}
