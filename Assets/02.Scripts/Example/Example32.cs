using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example32 : MonoBehaviour
{
    
    void Start()
    {
        // ���� �迭 (Jagged Array -> ���߳����� �迭)
        // 1������ ũ�⸦ �ٸ��� ������ �� �ִ�.
        // �ڷ���[][] �迭�� = new �ڷ���[���� ũ��][];  //[2������ ũ��][]

        // ���μ� : 3, 9
        // ������ : 0. 3. 9
        // ������ : 1, 4, 3, 9

        // 1����(����)�� ũ�Ⱑ ���߳����ϹǷ�
        // 2����(����) ũ�⸸ ���� ����
        int[][] lines = new int[3][];
        // 1����(����)�� ���߿� ���� ���� ũ�⸦ �������ش�.

        lines[0] = new int[] { 3, 9 };
        lines[1] = new int[] { 0, 3, 9 };
        lines[2] = new int[] { 1, 4, 3, 9 };
        
        // ��� �迭 �ȿ� �迭�� �ִ� ���´�.
    }

}
