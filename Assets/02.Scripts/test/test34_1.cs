using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test34_1 : MonoBehaviour
{
    public string Input = "65";

    void Start()
    {
        // �ƽ�Ű�ڵ� -> ����
        // int.Parse() : ������ ���ڿ� ǥ���� �ش��ϴ� 32��Ʈ ��ȣ �ִ� ������ ��ȯ
        int input_int = int.Parse(Input);
        char asc_c = (char)input_int;   //char asc_c = Convert.ToChar(input_int);
        Debug.Log(asc_c);
    }
}
