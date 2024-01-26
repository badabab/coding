using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example10 : MonoBehaviour
{
    public string myName = "���μ�";
    // Start is called before the first frame update
    void Start()
    {
        // 2. ����/���ڿ� ��
        // ���� : char (���� �ϳ�, ��������ǥ)
        // ���ڿ� : string (���� 2�� �̻�, ū����ǥ)

        char charValue1 = '��';
        char charValue2 = '1';
        char charValue3 = '+';
        string stringValue = "��ȫ��";
        Debug.Log($"{charValue1} {charValue2} {charValue3} {stringValue}");

        // ���ڿ��� �ٷ�� ���
        // 2-1. ���ڿ� ���� string.format
        //string str0 = "�ȳ� ��ȫ��";
        string str1 = string.Format("{0} {1}", "�ȳ�", myName); //("{0} {1} {2}", "�ȳ�", "�ϼ���", myName)
        // ù ��° ������ ���ڿ� ������ ������ ����
        // �� ��° �������� ���ڿ� ������ ����

        int hour = 1;
        int minute = 15;

        Debug.Log(string.Format("{0}{1}", hour, minute)); // 115
        Debug.Log(string.Format("{0}:{1}", hour, minute)); // 1:15
        Debug.Log(string.Format("���� �ð� : {0}:{1}", hour, minute)); // ���� �ð� : 1:15

        //����
        Debug.Log(string.Format("{0, -5}:{1}", hour, minute)); // 1:15
        Debug.Log(string.Format("{0:5}:{1}", hour, minute)); // 1:15

        // ���� ����
        Debug.Log(string.Format("{0:D5}:{1}", hour, minute)); // 00001:15


        float fValue = 3.124532f;

        // �Ҽ��� ����
        Debug.Log(string.Format("�Ҽ��� 1�ڸ��� ǥ�� : {0:F1}", fValue));
        


        // 2-2. ���ڿ� ����
        // $"�ؽ�Ʈ(����, ����)�ؽ�Ʈ"
        Debug.Log($"�Ҽ��� 1�ڸ��� ǥ�� : {fValue:F1}");



        // 2-3. Ž��

        // 2-4. ����

        // 2-5. ����
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
