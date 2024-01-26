using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Unity.VisualScripting;
using UnityEngine;

public class test28 : MonoBehaviour
{
    public int[] Num = { 3, 1, 4, 5, 7, 9, 6, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };

    void Start()
    {
        // logN^2
        /**
        for (int i = 0; i < Num.Length; i++)
        {
            for (int j = i + 1; j < Num.Length; j++)
            {
                if (Num[i] > Num[j])
                {
                    int temp = Num[i];
                    Num[i] = Num[j];
                    Num[j] = temp;
                }
            }
            // Debug.Log(Num[i]);
        }

        for (int i = 0; i < Num.Length -1; i++)
        {
            if (Num[i] + 1 != Num[i + 1])
            {
                Debug.Log(Num[i] + 1);
            }
        }
        **/


        //------------------
        // logN
        bool[] checks = new bool[30]; // 기본값은 모두 false
        for (int i = 0; i < Num.Length; i++)
        {
            int num = Num[i];

            checks[num-1] = true;
        }

        for(int i = 0; i < checks.Length; i++) 
        {
            if (checks[i] == false)
            {
                Debug.Log(i+1);
            }
        }
    }
}
