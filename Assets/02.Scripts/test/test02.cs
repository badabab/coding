using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test02 : MonoBehaviour
{
    public int A = 90;
    public int B = 50;
    public int C;

    // Start is called before the first frame update
    void Start()
    {

        C = A;
        A = B;
        B = C;

        Debug.Log(A);
        Debug.Log(B);
        
    }

  
}
