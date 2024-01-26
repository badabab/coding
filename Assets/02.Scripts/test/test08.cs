using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test08 : MonoBehaviour
{
    public int score;

    void Start()
    {
        switch (score)
        {
            case >= 90:
                {
                    Debug.Log("A");
                    break;
                }
            case >= 80:
                {
                    Debug.Log("B");
                    break;
                }
            case >= 70:
                {
                    Debug.Log("C");
                    break;
                }
            case >= 60:
                {
                    Debug.Log("D");
                    break;
                }
            default:
                {
                    Debug.Log("F");
                    break;
                }
        }
    }
}
