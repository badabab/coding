using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example36 : MonoBehaviour
{
    public int num = 0;
    // 반환 데이터가 없는 경우 : void
    void Hello()
    {
        return; // 반환 데이터가 없는 함수의 경우 return만 호출해서
                // 함수 중간에 종료 용도로 사용 가능하다.
        //Debug.Log("Hello");
    }

    // 함수 만들 때 4가지 경우의 수
    // 1. 반환 데이터 있고, 매개 변수 있는 함수            // int Sum(int, int)
    // 2. 반환 데이터 없고(void), 매개 변수 있는 함수      // void Test(int)
    // 3. 반환 데이터 있고, 매개 변수 없는 함수            // int GetLength()
    // 4. 반환 데이터 없고(void), 매개 변수 없는 함수      // void Hello()

    void Start()
    {
        Hello();

        // Q1. 매개변수로 정수를 하나 입력 받아서 홀수이면 true, 짝수이면 false를 반환하는 함수
        // 함수명 : IsOdd
        // ex) Debug.Log(3) -> true

        //Debug.Log(IsOdd(num));

        // Q2. Start 함수 내에서 1부터 100까지 for반복문을 돌면서 IsOdd 함수를 이용해 홀수만 출력
        for (int i = 1; i <= 100; i++)
        {
            // 만약 (홀수냐(i)? == true)
            if (IsOdd(i) == true)
            {
                Debug.Log(i);
            }
            continue;
        }
    }

    bool IsOdd(int num)
    {
        if (num % 2 == 0)
        {
            return false;
        }
        return true;
    }
}
