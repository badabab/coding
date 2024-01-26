using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Example30 : MonoBehaviour
{
    void Start()
    {
        // 2���� �迭: ���ο� ���� ���·� �� �迭
        // �޸�(,)�� �ε����� �����Ѵ�.
        // �ڷ���[,] �迭 �̸� = new �ڷ���[���� ũ��,���� ũ��];


        // �������� �ڸ��� 2���� �迭�� ǥ�� �غ��ô�.
        string[,] jari = new string[3, 5];

        jari[0, 0] = string.Empty; jari[0, 1] = string.Empty; jari[0, 2] = "�ο���"; jari[0, 3] = "������"; jari[0, 4] = "������";
        jari[1, 0] = "�輺��"; jari[1, 1] = "����ȯ"; jari[1, 2] = "��¿�"; jari[1, 3] = "������"; jari[1, 4] = "�����";
        jari[2, 0] = "�����"; jari[2, 1] = "������"; jari[2, 2] = "���μ�"; jari[2, 3] = "�̼���"; jari[2, 4] = "�迹��";

        for (int y = 0; y < 3; y++)
        {
            for(int x = 0; x < 5; x++)
            {
                Debug.Log(jari[y, x]);
            }
        }

        Debug.Log(jari.Length); // 15 -> �迭�� ����(ũ��) ����(3) * ����(5)
        Debug.Log(jari.GetLength(0));   // ������ ����
        Debug.Log(jari.GetLength(1));   // ������ ����
    }
}
