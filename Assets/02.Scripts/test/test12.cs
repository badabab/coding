using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test12 : MonoBehaviour
{
    /**
    public int A, B, C;

    void Start()
    {
        int A2, B2, B3;
        B2 = B + C;
        B3 = B2 % 60;
        
        if (B2 > 60) 
        {
            A2 = A + 1;
            B2 = B2 - 60;
            if (A2 >= 24)
            {
                A2 = A2 - 24;
            }
            Debug.Log($"{A2} {B2}");
        }
        else if (B3 == 0)
        {
            A2 = A + 1;
            B2 = 0;
            Debug.Log($"{A2} {B2}");
        }
        else
        {   
            if (B2 < 60)
            {
                Debug.Log($"{A} {B2}");
            }
        }
    }
    **/

    public int Hour = 14;
    public int Min = 30;

    public int AddMin = 20;

    void Start()
    {
        int newHour = Hour;
        int newMin = Min + AddMin;

        // ���� ���� 60�к��� ���ų� ũ��
        if (newMin >= 60)
        {
            newHour += (newMin / 60); // �ð��� �����ְ�
            newMin = (newMin % 60); // ���� ������
        }

        if (newHour >= 24)
        {
            newHour -= 24;
        }

        Debug.Log($"{newHour} {newMin}");
    }
}
