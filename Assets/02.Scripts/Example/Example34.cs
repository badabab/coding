using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example34 : MonoBehaviour
{
    // �Լ��� ������ �������� Ư�� �۾��� �����ϴ� �ڵ� ���
    // ���� 1: �ǹ� �ִ� �۾�(���) ������ �и�
    // ���� 2: ���� �����ϴ�.
    // ���� 3: �ݺ��Ǵ� �ڵ带 ���� �� �ִ�.

    /**
       // ��ȯ �ڷ����� ���� ��� : void
       '��ȯ �ڷ���' '�Լ� �̸�'('�Ű����� ���')
        {
            // ������ �ڵ��
            // return ��ȯ ������
        }
     **/

    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            // �Լ��� ȣ��(���)
            // �Լ��̸�();
            Hello();
        }
        
    }

    void Hello()
    {
        Debug.Log("�ȳ��ϼ���.");
    }
}
