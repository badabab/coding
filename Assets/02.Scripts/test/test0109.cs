using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class test0109 : MonoBehaviour
{
    public int MaxNum1 = 1, MaxNum2 = 3;
    public int AveNum1 = 10, AveNum2 = 28, AveNum3 = 30;
    public int IntNum = -5;

    void Start()
    {
        // ȣ�� : �Լ��̸�(�Ű�����);
        Debug.Log(4);


        Debug.Log(Max(MaxNum1, MaxNum2));
        Debug.Log(Average(AveNum1, AveNum2, AveNum3));
        LogNums(IntNum);

        Debug.Log(Mathf.Max(6, 4));

    }

    // Q1. ���� 2���� �Ű������� �Ѱܹ޾� �� �� �� �� ū ���� ��ȯ�ϴ� �Լ��� ����� �׽�Ʈ
    int Max(int num1, int num2)
    {
        if (num1 > num2)
        {
            return num1;
        }
        return num2;
    }

    // Q2. ���� 3���� �Ű������� �Ѱ� �޾� ����� ���� �����ϴ� �Լ��� ����� �׽�Ʈ (����� �Ҽ����� ����)
    float Average(int num1, int num2, int num3)
    {
        int sum = num1 + num2 + num3;
        return sum / 3f;    // ���� �ڿ� f ���̸� �Ǽ�(float)
    }

    // Q3. ���� 1���� �Ű������� �Ѱܹ޾� 0���� �ش� ���������� ������ִ� �Լ��� ����� �׽�Ʈ (��ȯ ����)
    void LogNums(int num)
    {
        if (num < 0)
        {
            for (int i = 0; i >= num; i--)
            {
                Debug.Log(i);
            }
            return;
        }
        for (int i = 0; i <= num; i++)
        {
            Debug.Log(i);
        }
    }
}
