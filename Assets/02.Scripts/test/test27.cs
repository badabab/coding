using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test27 : MonoBehaviour
{
    public int[] A = { 3, 29, 38, 12, 57, 74, 40, 85, 61 };

    void Start()
    {

        /**
        int max = A[0];
        int maxNum = 0;
        int i;
        for (i = 1; i < A.Length; i++)
        {
            if (max > A[i])
            {
                continue;
            }
            max = A[i];
            maxNum = i;
        }
        Debug.Log(max);
        Debug.Log(maxNum + 1); // ������ 0���� ����
        **/

        // ���� ū ���� ������ ���� (�⺻���� 0)
        int maxNumber = 0;
        int maxIndex = 0;

        for (int i = 0; i < A.Length; i++)
        {
            // 1. ���� ��ġ�� �ִ� �迭 ���� �����´�.
            int number = A[i];

            // 2. ���� ���� maxNumber���� ũ�� ��ü
            if (number > maxNumber)
            {
                // ���� ū �� ��ü
                maxNumber = number;
                // ���� ū ���� �ִ� ��ġ�� ��ü
                maxIndex = i;
            }
        }
        Debug.Log(maxNumber);
        Debug.Log(maxIndex + 1);
    }
}
