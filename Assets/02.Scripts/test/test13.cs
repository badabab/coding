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
        // 같은 눈이 3개가 나오면 10,000원 + (같은 눈)*1,000원의 상금
        if ((Dice1 == Dice2) && (Dice2 == Dice3) && (Dice1 == Dice3))
        {
            reward = 10000 + Dice1 * 1000;
        }
        // 같은 눈이 2개가 나오면
        // 1,000원 + (같은 눈) * 100원의 상금
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
            // 모두 다른 눈이 나오는 경우
            // (그 중 가장 큰 눈) * 100원의 상금
            if (Dice1 > Dice2 && Dice1 > Dice3)
            {
                // Dice1이 가장 크다
                reward = Dice1 * 100;
            }
            else if (Dice2 > Dice1 && Dice2 > Dice3)
            {
                // Dice2가 가장 크다
                reward = Dice2 * 100;
            }
            else if (Dice3 > Dice1 && Dice3 > Dice2)
            {
                // Dice3이 가장 크다
                reward = Dice3 * 100;
            }
        }
        Debug.Log(reward);
    }
}
