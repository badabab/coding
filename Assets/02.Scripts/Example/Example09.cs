using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example09 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 1. ������
        // 1-2. �Ǽ��� : �Ҽ����� �ִ� ����
        // float, double, decimal

        float floatValue = 3.141592653589793238462643383279f;  // 7�ڸ� ���е�
        double doubleValue = 3.141592653589793238462643383279;  // 15�ڸ� ���е�
        decimal decimalValue = 3.141592653589793238462643383279m;  //29�ڸ� ���е�

        Debug.Log(floatValue);
        Debug.Log(doubleValue);
        Debug.Log(decimalValue);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
