using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example13 : MonoBehaviour
{
    // �� �ڷ���
    // ���� ������ �����ϴ� �ڷ���
    // true (��), false (����)

    //bool isDie = false; // �׾��°�? -> ����
    //bool hasItem = true; // �������� ������ �ִ°�? -> ��

    private void Start()
    {
        // 4. �� (����) ������
        // ���� ��(����)�� ���ؼ� ����� true(��) �Ǵ� false(����)���� �Ǹ����ִ� ������
        // �� : �־��� ��(����)���� ������/������/ū��/�ٸ��� �� ����

        int num1 = 10;
        int num2 = 20;

        bool result1 = num1 == num2; // ������ �Ǵ�
        Debug.Log(result1);

        bool result2 = num1 != num2; // �ٸ��� �Ǵ�
        Debug.Log(result2);

        bool result3 = num1 > num2; // ���� ���� �� ū�� �Ǵ�
        Debug.Log(result3);

        bool result4 = num1 >= num2; // ���� ���� �� ũ�ų� ������ �Ǵ�
        Debug.Log(result4);

        int playerHealth = 100;
        int monsterDamage = 80;

        bool isDeath = playerHealth <= monsterDamage;
    }
}
