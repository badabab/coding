using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example18 : MonoBehaviour
{
    void Start()
    {
        // 2. �б⹮ : ������ �ƴ϶� ���� ���� �б� (������ �ڵ��� ����)�� ���� �� �ִ�.
        // switch - case
        /**
         switch ( �˻��� ����(��) )
        {
            case ��1:
            {
                ������ ���� ��1�� �� ������ �ڵ��
                break;
            }

            case ��2:
            {
                ������ ���� ��2�� �� ������ �ڵ��
                break;
            }

            default:
            {
                ���� ���� ��� �ƴ� �� ������ �⺻ �ڵ��
                break;
            }
        }
         **/


        // ������ �ֹ� ��ȣ�� ���� �ٸ� ������� ���
        // 1�� ���� : �ݶ�
        // 2�� ���� : ���̴�
        // �� �� : ��

        int orderNumber = 3;

        switch (orderNumber)
        {
            case 1:
                {
                    Debug.Log("�ݶ�");
                    break;
                }
            case 2: 
                {
                    Debug.Log("���̴�");
                    break;
                }

            default:
                {
                    Debug.Log("��");
                    break;
                }
        }
    }
}
