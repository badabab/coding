using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test30 : MonoBehaviour
{
    public int[] Num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    void Start()
    {
        int[] result = new int[Num.Length];

        for (int i = 0; i < Num.Length; i++)
        {
            int j = Num[i] % 42;
            result[i] = j;
        }

        int count = 0;
        bool[] checks = new bool[42]; // 기본값은 모두 false
        // 나머지는 0 ~ 41
        for (int i = 0; i < result.Length; i++)
        {
            if (checks[result[i]] == false)
            {
                count += 1;
                checks[result[i]] = true;
            }
        }
        Debug.Log(count);
    }
}
