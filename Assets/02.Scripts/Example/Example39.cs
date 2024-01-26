using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example39 : MonoBehaviour
{
    void Swap(ref int num1, ref int num2)
    {
        int tempNum = num1;
        num1 = num2;
        num2 = tempNum;
    }

    void Test(out int num)
    {
        // ref Ű����� �Լ� ���ο��� ���� ������ ���� �������� �ʾƵ� ������
        // out Ű����� �Լ� ���ο��� ������ ���� ������ ���� �����ؾ� �Ѵ�.
        // ref�� ��������� �������� �Ǽ��� �ٿ��ش�.

        num = 3;
    }
    
    void Start()
    {
        int num1 = 3;
        int num2 = 9;
        Debug.Log($"�ٲ�� �� : num1={num1}, num2={num2}");

        Swap(ref num1, ref num2);
        Debug.Log($"�ٲ� �� : num1={num1}, num2={num2}");

        Test(out num1);
    }
}
