using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example37 : MonoBehaviour
{
    int Add(int num1, int num2)  // ������
    {
        Debug.Log("������ ���ϱ�");
        return num1 + num2;
    }
    int Add(int num1, int num2, int num3)
    {
        return num1 + num2 + num3;
    }

    float Add(float num1, float num2)  // �Ǽ���
    {
        Debug.Log("�Ǽ��� ���ϱ�");
        return num1 + num2;
    }
    // �Լ�(�޼ҵ�) �����ε� : ���� �Լ� �̸����� ���� ������ �Լ��� �����ϴ� ��
    // - C# �ؼ���� �ڵ����� �Ű������� ������ ������ Ÿ���� �м��ؼ� �Լ��� ���� �� ȣ��
    // (��ȯ Ÿ�Ը� �ٸ��� �ϴ� ���� X)
    // ex) string.Format

    void Start()
    {
        Debug.Log(Add(3, 4));
        Debug.Log(Add(3f, 4f));
        Debug.Log(Add(1, 2, 3));
    }
}
