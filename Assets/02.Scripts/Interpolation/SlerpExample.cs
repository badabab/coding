using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 구면선형보간(Slerp: Sphercial Linear Interpolation) ->
// 직선 형태가 아닌 "구면" 형태로 값을 추론한다.
// 시작점과 종료점은 느리게 증가하고, 중간지점은 빠르게 이동하는 특성
// -> 자연스러운 회전 로직에 많이 사용한다.

public class SlerpExample : MonoBehaviour
{
    public Transform Start;
    public Transform End;

    private float _progress;    // 진행률: 0 ~ 1 //_timer
    public float Duration = 3f;

    void Update()
    {
        _progress += Time.deltaTime / Duration;
        if (_progress > 1)
        {
            _progress = 0;
            Transform temp = Start;
            Start = End;
            End = temp;
        }
        transform.position = Vector3.Slerp(Start.position, End.position, _progress);
    }
}