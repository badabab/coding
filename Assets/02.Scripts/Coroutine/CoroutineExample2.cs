using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineExample2 : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(Timer_Coroutine(3));
    }

    private IEnumerator Timer_Coroutine(float delayTime)
    {
        int count = 10;
        while (true) // 무한반복
        {
            // 주어진 시간만큼 대기
            yield return new WaitForSeconds(delayTime);
            Debug.Log("딩동댕동");
            count--;
            if (count <= 0)
            {
                yield break; // 코루틴 종료
            }
        }       
    }
}
