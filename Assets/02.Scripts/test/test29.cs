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
        int aLength = A.Length; // �迭 A�� ����
        int[] B = new int[aLength]; // �迭 A�� ���̰� ���� �迭 B ����

        // 1. �迭 A�� �� ����� ���� B�� �����Ѵ�.
        for (int i = 0; i < aLength; i++)
        {
            B[i] = A[i];
        }

        // 2. �迭 B�� �� ����� ���� �Ųٷ� A�� �����Ѵ�.
        // B[5] -> A[0]
        // B[4] -> A[1]
        // ...
        // B[0] -> A[5] <- A[A.Length - i - 1] = B[i]
        for (int i = 0;i < aLength; ++i)
        {
            A[A.Length - i - 1] = B[i];
        }

        // 3. �迭 A�� �� ��� ���� ����Ѵ�.
        foreach (int num in A)
        {
            Debug.Log(num);
        }
    }
}
