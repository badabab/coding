using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example26 : MonoBehaviour
{   
    void Start()
    {
        string firstName = "��";
        string lastName = "�μ�";
        string displayName = string.Empty;  // �̸� : ���μ�

        // ���ڿ��� ���� ���� ���� ���
        // 1. ���ϱ�(+) ������ ���
        displayName = "�̸� : " + firstName + lastName;
        Debug.Log(displayName);

        // 2. string.Format ���
        displayName = string.Format("�̸� : {0}{1}", firstName, lastName);
        Debug.Log(displayName);

        // 3. ���ڿ� ������($) ���
        displayName = $"�̸� : {firstName}{lastName}";
        Debug.Log(displayName);
    }
}
