using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example35_1 : MonoBehaviour
{
    void Start()
    {
        // ���ϱ�
        int result = Add(3, 5);
        Debug.Log(result);

        // ����
        Sub(17, 9);
        Debug.Log(result);

        // ���ϱ�
        Multiply(22, 55);

        // ������
        Divide(22, 3);
    }

    /**
       // ��ȯ �ڷ����� ���� ��� : void
       '��ȯ �ڷ���' '�Լ� �̸�'('�Ű����� ���')
        {
            // ������ �ڵ��
            // return ��ȯ ������
        }
     **/

    // 1. �Ű�������: �Լ��� ȣ��(����)�� �� ���޵Ǵ� ��
    // 2. return�̶�
    //  - return�� ȣ��Ǹ� �Լ��� ����
    //  - ���α׷��� �帧�� ȣ���ڿ� �����ش�.
    //  - �̶� Ư�� '��ȯ �ڷ���'�� �����͸� ��ȯ�Ѵ�.

    // Sum�̶�� �Լ��� �Ű� ���� 2���� �޾Ƽ� ���� ó�� �� int �ڷ����� �����ͷ� �����ִ� �Լ���.
    int Add(int num1, int num2) 
    {
        int result = num1 + num2;
        return result;

        // ������ return�� ȣ���� �Լ��� �����Ͽ����Ƿ� �Ʒ� �ڵ�� ������� �ʴ´�.
        //Debug.Log(11111);
    }
    int Sub(int num1, int num2)
    {
        int result = num1 - num2;
        return result;
    }
    void Multiply(int num1, int num2)
    {
        int result = num1 * num2;
        Debug.Log(result);
        return;
    }
    void Divide(int num1, int num2)
    {
        int result = num1 / num2;
        Debug.Log(result);
        return;
    }
}
