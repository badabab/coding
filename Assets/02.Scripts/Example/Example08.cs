using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example08 : MonoBehaviour
{
    // �ѱ��� ������.
    // Start is called before the first frame update
    void Start()
    {
        // C# ���� �⺻���� �����ϴ� ������ Ÿ���� 16����

        // 1. ������
        // 1-1. ������ :
        // byte, short, int, long

        sbyte byteValue = 3;
        short shortValue = 3;
        int intValue = 3;
        long longValue = 3;

        Debug.Log(sbyte.MinValue);
        Debug.Log(sbyte.MaxValue);

        Debug.Log(short.MinValue);
        Debug.Log(short.MaxValue);

        Debug.Log(int.MinValue);
        Debug.Log(int.MaxValue);

        Debug.Log(long.MinValue);
        Debug.Log(long.MaxValue);

        Debug.Log(byteValue);
        Debug.Log(shortValue);
        Debug.Log(intValue);
        Debug.Log(longValue);

        // �ʿ��� ���� �������� ������ ū �ڷ����� ����?
        // -> ���ǹ��ϰ� �������� ������ ������ ��������. -> �޸� ���� ����

        // �ʿ��� ���� �������� ������ ���� �ڷ����� ����?
        // -> �����÷ο� or ����÷ο찡 �߻��Ѵ�. -> ����
        int number = int.MaxValue;
        number = number + 1; // ���� �÷ο�

        number = int.MinValue;
        number = number - 1; // ��� �÷ο�

        Debug.Log(number);


        // 1-2 ��ȣ���� ������ :
        // ��ȣ�� ���� -> +, -�� ����. (������ ���, ����� 2��� ����)
        byte bValue = 5;
        ushort ushortValue = 5;
        uint uintValue = 5;
        ulong ulongValue = 5;

        Debug.Log(bValue);
        Debug.Log(ushortValue);
        Debug.Log(uintValue);
        Debug.Log(ulongValue);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
