using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test43 : MonoBehaviour
{
    public int N = 5;

    void Start()
    {
        for (int i = 0; i < N; i++)
        {
            string spaces = new string(' ', N - i - 1);
            string stars = new string('*', 2 * i + 1);
            string line = spaces + stars;

            Debug.Log(line);
        }
        for (int i = N - 2; i > -1; i--)
        {
            string spaces2 = new string(' ', N - i - 1);
            string stars2 = new string('*', 2 * i + 1);
            string line2 = spaces2 + stars2;
            Debug.Log(line2);
        }
    }
}
