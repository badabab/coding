using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example17 : MonoBehaviour
{
    public string Id;   // public�� �빮�ڷ� ����
    public string Password;

    const string ID = "teemo";  // const : ���
    const string PASSWORD = "1234";

    void Start()
    {
        // 1. ID�� �ٸ��� ��� : "�������� �ʴ� ID�Դϴ�."
        if (Id != ID)
        {
            Debug.Log("�������� �ʴ� ID�Դϴ�.");
        }
        else
        {
            // ��ø ���ǹ� : ���ǹ� �ȿ� �� �ٸ� ���ǹ��� �� �ִ� ����
            // 3�� ���ǹ��� �Ǹ� '���� ���� �߸��ϰ� ���� ������?' �����غ���.
            // 2. ID�� ������ ��й�ȣ�� �ٸ��� ��� : "��й�ȣ�� Ʋ�Ƚ��ϴ�."
            if (Password != PASSWORD)
            {
                Debug.Log("��й�ȣ�� Ʋ�Ƚ��ϴ�.");
            }
            // 3. ID�� ��й�ȣ�� ��� ������ ��� : "�α��� �ƽ��ϴ�."
            else
            {
                Debug.Log("�α��� �ƽ��ϴ�.");
            }
        }
    }
}
