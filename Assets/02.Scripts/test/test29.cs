using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test29 : MonoBehaviour
{
    //public int[] Num = { 10, 20, 30, 40, 50, 60 };
    void Start()
    {
        /**
        int[] Num2 = new int[Num.Length];
        for (int i = 0; i < Num.Length; i++)
        {
            Num2[i] = Num[i];
        }
        for (int i = 0;i < Num2.Length; i++)
        {
            Num[i] = Num2[Num.Length - i - 1];
        }
        for(int i = 0; i < Num2.Length; i++)
        {
            Debug.Log(Num[i]);
        }
        **/

        int[] A = { 10, 20, 30, 40, 50, 60 };
        int aLength = A.Length; // 배열 A의 길이
        int[] B = new int[aLength]; // 배열 A와 길이가 같은 배열 B 생성

        // 1. 배열 A의 각 요소의 값을 B로 복사한다.
        for (int i = 0; i < aLength; i++)
        {
            B[i] = A[i];
        }

        // 2. 배열 B의 각 요소의 값을 거꾸로 A로 복사한다.
        // B[5] -> A[0]
        // B[4] -> A[1]
        // ...
        // B[0] -> A[5] <- A[A.Length - i - 1] = B[i]
        for (int i = 0;i < aLength; ++i)
        {
            A[A.Length - i - 1] = B[i];
        }

        // 3. 배열 A의 각 요소 값을 출력한다.
        foreach (int num in A)
        {
            Debug.Log(num);
        }
    }
}
