using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example35_1 : MonoBehaviour
{
    void Start()
    {
        // 더하기
        int result = Add(3, 5);
        Debug.Log(result);

        // 빼기
        Sub(17, 9);
        Debug.Log(result);

        // 곱하기
        Multiply(22, 55);

        // 나누기
        Divide(22, 3);
    }

    /**
       // 반환 자료형이 없을 경우 : void
       '반환 자료형' '함수 이름'('매개변수 목록')
        {
            // 실행할 코드들
            // return 반환 데이터
        }
     **/

    // 1. 매개변수란: 함수를 호출(실행)할 때 전달되는 값
    // 2. return이란
    //  - return이 호출되면 함수를 종료
    //  - 프로그램의 흐름을 호출자에 돌려준다.
    //  - 이때 특정 '반환 자료형'의 데이터를 반환한다.

    // Sum이라는 함수는 매개 변수 2개를 받아서 뭔가 처리 후 int 자료형의 데이터로 돌려주는 함수다.
    int Add(int num1, int num2) 
    {
        int result = num1 + num2;
        return result;

        // 위에서 return을 호출해 함수를 종료하였으므로 아래 코드는 실행되지 않는다.
        //Debug.Log(11111);
    }
    int Sub(int num1, int num2)
    {
        int result = num1 - num2;
        return result;
    }
    void Multiply(int num1, int num2)
    {
        int result = num1 * num2;
        Debug.Log(result);
        return;
    }
    void Divide(int num1, int num2)
    {
        int result = num1 / num2;
        Debug.Log(result);
        return;
    }
}
