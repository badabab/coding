using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Example16 : MonoBehaviour
{
    public int temperature;
   
    void Start() // ó���� �� �� ����
    {
        // �ڵ�� ������ �Ʒ��� (����������) ����Ǵ� �帧�� ������ �ִ�. -> �������� �帧
        Debug.Log(1);
        Debug.Log(2);
        Debug.Log(3);

        // ��� : ������ �Ʒ��� ����Ǵ� �帧�� ����
        // ����� ���� : ���ǹ�, �б⹮, �ݺ���


        // 1. ���ǹ�(if��)
        // ���ǿ� ���� �´� ��Ȳ�� �����ϴµ� ���δ�.
        // ������ ���ǽĿ� ���� "���� ������", "������ ����" ���� �� �ִ�.
        // ���ǽ� : �� �����ڸ� ���� ��
        //         - ���� ��(����)�� ���ؼ� ����� true(��) �Ǵ� false(����)���� �Ǹ����ִ� ������
        //         - �񱳶� : �־��� ������ ������ �ٸ��� ū�� ������ �����ϴ� ���� �ǹ�

        // if : ���� ~���? ~�Ѵ�.
        // else : �׷��� �ʴٸ�? ~�Ѵ�.

        // if : ���� ~���? ~�Ѵ�.
        // else if : �׷��� �ʰ� ~���? ~�Ѵ�.
        // else : �̵����� �ƴ϶��? ~�Ѵ�.

        /**
         if(���ǽ�) ���� ~���
        {
            ~�Ѵ�.
            ���ǽ��� ��(true)�̸� ������ �ڵ��
        }
        **/

        int health = 100;
        int damage = 200;

        health -= damage;

        if (health <= 0)
        {
            Debug.Log("���� ����");
        }
        else
        {
            Debug.Log("���� ��� ����");
        }

        Debug.Log("!");


        //int temperature = 0;
        // �µ��� 12�� ���ϰ� �Ǹ� "�������Ǻ�"��� �ؽ�Ʈ�� ���
        if (temperature <= 12)
        {
            Debug.Log("�������Ǻ�");
        }
        // �µ��� 36�� �̻��̸� "�������Ǻ�"��� �ؽ�Ʈ�� ���
        else if (temperature >= 36)
        {
            Debug.Log("�������Ǻ�");
        }
        // �µ��� 12�� �ʰ� 36�� �̸��̸� "���� �µ�"��� �ؽ�Ʈ�� ���
        //else if (temperature > 12 && temperature < 36)
        else
        {
            Debug.Log("���� �µ�");
        }

        // ���� �µ� �˷��ִ� �ؽ�Ʈ��� : "���� �µ� : 00��"
        Debug.Log($"���� �µ� : {temperature}��");
    }
                                                      
    // Update is called once per frame
    void Update() // �� ������(ȭ��)���� ����
    {
        
    }
}
