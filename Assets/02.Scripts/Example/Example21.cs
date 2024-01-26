using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example21 : MonoBehaviour
{
    void Start()
    {
        // 3-3. 점프문 : 반복문의 제어문
        // for, while 반복문 내부에서 흐름을 끊고 실행 위치를 원하는 곳으로 점프(이동)할 수 있다.
        // break, continue

        // 숫자 1부터 10까지 출력하는 for 반복문
        for (int i = 1; i <= 10; i++)
        {
            if (i == 5) // i가 5가 되면
            {
                // 반복문을 종료해버린다.
                break;
                // break : 현재 실행중인 반복문이나 switch문의 실행을 중단할 때 사용한다.
                // (종료, 탈출이라고 표현)
            }

            Debug.Log(i);
        }
        Debug.Log("반복문 종료");
    }
}
