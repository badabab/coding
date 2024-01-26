using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test34_1 : MonoBehaviour
{
    public string Input = "65";

    void Start()
    {
        // 아스키코드 -> 문자
        // int.Parse() : 숫자의 문자열 표현을 해당하는 32비트 부호 있는 정수로 변환
        int input_int = int.Parse(Input);
        char asc_c = (char)input_int;   //char asc_c = Convert.ToChar(input_int);
        Debug.Log(asc_c);
    }
}
