using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example33 : MonoBehaviour
{
    
    void Start()
    {
        // ������ ���� �迭 �ʱ�ȭ ���
        int[][] numbers = new int[3][]
        {
            new int[] { 1, 2, 3 },
            new int[] { 10, 20, 30, 40 },
            new int[] {100, 200, 300, 400, 500}
        };

        // Q. �� ���� �迭�� ��� �������� ����غ�����.
        Debug.Log(numbers.Length);  // 3 -> 2����(����)�� ũ�⸦ �� �� ����.
        
        Debug.Log(numbers[0].Length);   // 3
        Debug.Log(numbers[1].Length);   // 4
        Debug.Log(numbers[2].Length);   // 5

        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = 0; j < numbers[i].Length; j++)
            {
                Debug.Log(numbers[i][j]);
            }
        }       
    }
}
