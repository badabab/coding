using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test31 : MonoBehaviour
{
    public string S = "shiftpsh";
    public int i = 6;
    
    void Start()
    {
        S = S.ToUpper();
        Debug.Log(S[i-1]);       
    }
}
