using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Curve(곡선): 연속적인 점의 집합

public class CurveExample : MonoBehaviour
{
    // 보간을 시각적으로 볼 수 있는 그래프 에디터
    public AnimationCurve Curve;

    public Transform Start;
    public Transform End;

    private float _progress;    // 진행률: 0 ~ 1 
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
        transform.position = Vector3.Slerp(Start.position, End.position, Curve.Evaluate(_progress));
    }
}
