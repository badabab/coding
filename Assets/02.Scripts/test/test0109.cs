using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class test0109 : MonoBehaviour
{
    public int MaxNum1 = 1, MaxNum2 = 3;
    public int AveNum1 = 10, AveNum2 = 28, AveNum3 = 30;
    public int IntNum = -5;

    void Start()
    {
        // 호출 : 함수이름(매개변수);
        Debug.Log(4);


        Debug.Log(Max(MaxNum1, MaxNum2));
        Debug.Log(Average(AveNum1, AveNum2, AveNum3));
        LogNums(IntNum);

        Debug.Log(Mathf.Max(6, 4));

    }

    // Q1. 정수 2개를 매개변수로 넘겨받아 두 수 중 더 큰 수를 반환하는 함수를 만들고 테스트
    int Max(int num1, int num2)
    {
        if (num1 > num2)
        {
            return num1;
        }
        return num2;
    }

    // Q2. 정수 3개를 매개변수로 넘겨 받아 평균을 구해 리턴하는 함수를 만들고 테스트 (평균은 소수점이 있음)
    float Average(int num1, int num2, int num3)
    {
        int sum = num1 + num2 + num3;
        return sum / 3f;    // 정수 뒤에 f 붙이면 실수(float)
    }

    // Q3. 정수 1개를 매개변수로 넘겨받아 0부터 해당 정수값까지 출력해주는 함수를 만들고 테스트 (반환 안함)
    void LogNums(int num)
    {
        if (num < 0)
        {
            for (int i = 0; i >= num; i--)
            {
                Debug.Log(i);
            }
            return;
        }
        for (int i = 0; i <= num; i++)
        {
            Debug.Log(i);
        }
    }
}
