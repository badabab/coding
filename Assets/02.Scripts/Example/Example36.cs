using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example36 : MonoBehaviour
{
    public int num = 0;
    // ��ȯ �����Ͱ� ���� ��� : void
    void Hello()
    {
        return; // ��ȯ �����Ͱ� ���� �Լ��� ��� return�� ȣ���ؼ�
                // �Լ� �߰��� ���� �뵵�� ��� �����ϴ�.
        //Debug.Log("Hello");
    }

    // �Լ� ���� �� 4���� ����� ��
    // 1. ��ȯ ������ �ְ�, �Ű� ���� �ִ� �Լ�            // int Sum(int, int)
    // 2. ��ȯ ������ ����(void), �Ű� ���� �ִ� �Լ�      // void Test(int)
    // 3. ��ȯ ������ �ְ�, �Ű� ���� ���� �Լ�            // int GetLength()
    // 4. ��ȯ ������ ����(void), �Ű� ���� ���� �Լ�      // void Hello()

    void Start()
    {
        Hello();

        // Q1. �Ű������� ������ �ϳ� �Է� �޾Ƽ� Ȧ���̸� true, ¦���̸� false�� ��ȯ�ϴ� �Լ�
        // �Լ��� : IsOdd
        // ex) Debug.Log(3) -> true

        //Debug.Log(IsOdd(num));

        // Q2. Start �Լ� ������ 1���� 100���� for�ݺ����� ���鼭 IsOdd �Լ��� �̿��� Ȧ���� ���
        for (int i = 1; i <= 100; i++)
        {
            // ���� (Ȧ����(i)? == true)
            if (IsOdd(i) == true)
            {
                Debug.Log(i);
            }
            continue;
        }
    }

    bool IsOdd(int num)
    {
        if (num % 2 == 0)
        {
            return false;
        }
        return true;
    }
}
