using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example19 : MonoBehaviour
{
    void Start()
    {
        // 3. �ݺ���
        // �ݺ����� ������ ������ ��(true)�� ���� �ڵ� ��� ���� ("{}")�� �ݺ��ؼ� �����ϴ� ��
        // for, while

        // 3-1. for
        /**
         for �ݺ����� ��ȣ ���ο�
         for(��ȣ ����)
            - �ʱ��;
            - ���ǽ�;
            - ������

         for(�ʱ��; ���ǽ�; ������)
         {
                // �ݺ��� �ڵ��...
         }
        // �ʱ�� : �ʱ�ȭ
        // ���ǽ� : �� ������
        // ������ : ��� ����, ++, --
         **/

        for (int i = 0; i < 1000; i++)
        {
            Debug.Log("�ȳ��ϼ���. �� �̸��� Ƽ���Դϴ�.");
        }

    }

}
