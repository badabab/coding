using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example12 : MonoBehaviour
{
    //����(���)�̶� ����� ���� ���ο� ���� ����� ��
    //"������"�� ������ ������ �� ���� ��ȣ

    // Start is called before the first frame update
    void Start()
    {
        // 1. ��Ģ������
        // +, -, / (��), * (���ϱ�), % (������)
        int a = 5;
        int b = 3;

        Debug.Log($"{a}+{b}={a + b}");
        Debug.Log($"{a}-{b}={a - b}");
        Debug.Log($"{a}/{b}={a / b}");
        Debug.Log($"{a}*{b}={a * b}");
        Debug.Log($"{a}%{b}={a % b}");

        // 2. ���� ������
        // (�����) ���� ������ ����(�Ҵ�)�ϴ� ������
        int c = 3;

        // 00 ���� ������
        c = c + 5;
        c += 5;
        Debug.Log($"c+=5: {c}");

        c -= 3;
        Debug.Log($"c-=3: {c}");

        c *= 3;
        Debug.Log($"c*=3: {c}");

        c /= 7;
        Debug.Log($"c/=7: {c}");

        // ����(����/����) ������
        // ex) 1�� ���� ��...
        c = c + 1; // ���� ������
        c += 1; // ���� ���� ������
        c++; // 1 ���� ������
        c--; // 1 ���� ������

        ++c;

        int number = 10;
        Debug.Log(number); // 10

        Debug.Log(number++); // 10  ���� ���� : �ٸ� ������ ���� ���� ��, �� 1 ����
        Debug.Log(number); // 11

        Debug.Log(++number); // 12   ���� ���� : �� 1 ���� �� �ٸ� ���� ����
        Debug.Log(number); // 12

    }

}
