using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example21 : MonoBehaviour
{
    void Start()
    {
        // 3-3. ������ : �ݺ����� ���
        // for, while �ݺ��� ���ο��� �帧�� ���� ���� ��ġ�� ���ϴ� ������ ����(�̵�)�� �� �ִ�.
        // break, continue

        // ���� 1���� 10���� ����ϴ� for �ݺ���
        for (int i = 1; i <= 10; i++)
        {
            if (i == 5) // i�� 5�� �Ǹ�
            {
                // �ݺ����� �����ع�����.
                break;
                // break : ���� �������� �ݺ����̳� switch���� ������ �ߴ��� �� ����Ѵ�.
                // (����, Ż���̶�� ǥ��)
            }

            Debug.Log(i);
        }
        Debug.Log("�ݺ��� ����");
    }
}
