using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example23 : MonoBehaviour
{
    void Start()
    {
        //string studentName1 = "�迹��";
        //string studentName2 = "�̼���";
        //string studentName3 = "���μ�";

        // 1. �迭�̶�
        // ���� �ڷ����� �����͸� �� �׷����� ��� ����ϴ� ��
        // (������ �����͸� ��Ƽ� �����ϱ� ���� ���)

        // �ڷ���[] �迭�� = new �ڷ���[ũ��]
        int size = 3;
        string[] studentNames = new string[size];

        // �ε��� : �� ���(������)�� ��ġ�� ��Ÿ���� ��ȣ��.
        // (0������ �����Ѵ�.)
        studentNames[0] = "�迹��";
        studentNames[1] = "�̼���";
        studentNames[2] = "���μ�";

        // Debug.Log(studentNames[0]);
        // Debug.Log(studentNames[1]);
        // Debug.Log(studentNames[2]);
         


        for (int i = 0; i <= 2; i++)
        {
            Debug.Log(studentNames[i]);
        }
         

    }
}
