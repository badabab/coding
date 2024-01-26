using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example39 : MonoBehaviour
{
    void Swap(ref int num1, ref int num2)
    {
        int tempNum = num1;
        num1 = num2;
        num2 = tempNum;
    }

    void Test(out int num)
    {
        // ref 키워드는 함수 내부에서 원본 변수의 값을 수정하지 않아도 되지만
        // out 키워드는 함수 내부에서 무조건 원본 변수의 값을 수정해야 한다.
        // ref와 비슷하지만 개발자의 실수를 줄여준다.

        num = 3;
    }
    
    void Start()
    {
        int num1 = 3;
        int num2 = 9;
        Debug.Log($"바뀌기 전 : num1={num1}, num2={num2}");

        Swap(ref num1, ref num2);
        Debug.Log($"바뀐 후 : num1={num1}, num2={num2}");

        Test(out num1);
    }
}
