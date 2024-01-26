using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test42 : MonoBehaviour
{
    public int[] Piece = {0, 1, 2, 2, 2, 7};

    void Start()
    {
        int[] correctPiece = {1, 1, 2, 2, 2, 8};
        int[] result = new int[Piece.Length];
        string output = "";
        
        for (int i = 0; i < Piece.Length; i++)
        {
            result[i] = correctPiece[i] - Piece[i];
            output += result[i] + " ";
        }
        Debug.Log(output);
    }
}
