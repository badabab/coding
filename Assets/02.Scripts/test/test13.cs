using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class test13 : MonoBehaviour
{
    /**
    public int A, B, C;
    
    void Start()
    {
       if (A == B && B == C)
        {
            Debug.Log(10000 + A * 1000);
        }
       else if ( (A == B && B != C) || (A == C && C != B) )
        {
            Debug.Log(1000 + A * 100);
        }
       else if (B == C && C != A)
        {
            Debug.Log(1000 + B * 100);
        }
       else
        {
            if (A > B && A > C)
            {
                Debug.Log(A * 100);
            }
            else if ( B > C && B > A)
            {
                Debug.Log(B * 100);
            }
            else
            {
                Debug.Log(C * 100);
            }
        }
    }
    **/

    public int Dice1 = 3;
    public int Dice2 = 3;
    public int Dice3 = 6;
    void Start()
    {
        int reward = 0;
        // ���� ���� 3���� ������ 10,000�� + (���� ��)*1,000���� ���
        if ((Dice1 == Dice2) && (Dice2 == Dice3) && (Dice1 == Dice3))
        {
            reward = 10000 + Dice1 * 1000;
        }
        // ���� ���� 2���� ������
        // 1,000�� + (���� ��) * 100���� ���
        else if (Dice1 == Dice2 || Dice2 == Dice3 || Dice1 == Dice3)
        {
            if (Dice1 == Dice2)
            {
                reward = 1000 + Dice1 * 100;
            }
            else if (Dice2 == Dice3)
            {
                reward = 1000 + Dice2 * 100;
            }
            else if (Dice1 == Dice3)
            {
                reward = 1000 + Dice3 * 100;
            }
        }
        else
        {
            // ��� �ٸ� ���� ������ ���
            // (�� �� ���� ū ��) * 100���� ���
            if (Dice1 > Dice2 && Dice1 > Dice3)
            {
                // Dice1�� ���� ũ��
                reward = Dice1 * 100;
            }
            else if (Dice2 > Dice1 && Dice2 > Dice3)
            {
                // Dice2�� ���� ũ��
                reward = Dice2 * 100;
            }
            else if (Dice3 > Dice1 && Dice3 > Dice2)
            {
                // Dice3�� ���� ũ��
                reward = Dice3 * 100;
            }
        }
        Debug.Log(reward);
    }
}
