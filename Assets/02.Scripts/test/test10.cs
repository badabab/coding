using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test10 : MonoBehaviour
{
    public int X, Y;
    // (−1000 ≤ x ≤ 1000; x ≠ 0) (−1000 ≤ y ≤ 1000; y ≠ 0)

    void Start()
    {
        if (Y > 0)
        {
            if (X > 0)
            {
                Debug.Log("1");
            }
            else
            {
                Debug.Log("2");
            }
        }
        else
        {
            if (X > 0)
            {
                Debug.Log("4");
            }
            else
            {
                Debug.Log("3");
            }
        }
    }
}
