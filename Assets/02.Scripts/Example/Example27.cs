using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example27 : MonoBehaviour
{
    void Start()
    {
        // ����
        //char a = 't';

        // ���ڿ� : ���� + �迭�� ���Ӹ�
        string b = "Hello";
        Debug.Log(b.Length);    // ���ڿ��� �迭ó�� ���̸� �� �� �ִ� Length �Ӽ��� �ִ�.
        Debug.Log(b[0]);
        Debug.Log(b[1]);
        Debug.Log(b[2]);
        
        // b[0] = 'K'; // ���ڿ� ���� ���� ���� ������ �� ����. -> �Һ��� ������ ������ �ִ�.

        string c = "Hello";
        c = c + 'K';    // ���ڿ��� ���� ���� ��� ���������δ� ���� �����.        
    }
}
