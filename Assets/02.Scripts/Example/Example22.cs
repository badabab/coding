using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example22 : MonoBehaviour
{
    void Start()
    {
        // ���� 1���� 10���� ����ϴ� for �ݺ���
        for (int i = 1; i <= 10; i++)
        {
            if (i == 5)
            {
                continue;
                // continue : �ݺ������� �Ʒ� �ڵ���� ������ �ǳʶ� �� ���
                // -> �ݺ��� ����ϰ� �ٽ� ���� �ݺ��� �����Ѵ�.
            }
            Debug.Log(i);
        }  
        
        // 1���� 100���� for���� continue�� �̿��ؼ� ¦���� ����ϱ�
        for (int i = 1; i <= 100; i++)
        {
            int j = i % 2;
            if (j != 0)
            {
                continue;
            }
            else
            {
                Debug.Log(i);
            }
        }

        // break : �ݺ��� ��� �ȿ��� ������ �ߴ��ϰ� Ż���� �� ���
        // continue : �ݺ����� �ݺ��� �� �� ����ϰ� ���� �ݺ��� ������ �� ���
    }
}
