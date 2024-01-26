using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticTest : MonoBehaviour
{
    void Start()
    {
        MyStudent student1 = new MyStudent("���μ�", 11);
        MyStudent student2 = new MyStudent("�̼���", 12);
        MyStudent student3 = new MyStudent("�迹��", 13);

        // student1.Hello(); -> ����
        MyStudent.Hello();

        Debug.Log($"���� �л��� �� : {MyStudent.GetNumber()}��");

        // static�� ��ƿ��Ƽ ���� �Լ��� ����ų� ����� �� �����ϴ�.
        // ��ƿ��Ƽ �Լ� : ���� ���� �� �ݺ������� ���Ǵ� �����ϰ� �ǿ����� �Լ�
        // string(���ڿ�), Mathf(����), Vector2(����), Debug(�����)
        string.Format("{0}", 1);
        Mathf.Max(1, 2, 3, 43);
        Vector2 dir = Vector2.up;
        Debug.Log(123);
        // static ���� ����
        // 1. ���ټ�
        // ��𿡼��� ������ ��ü �������� Ŭ���� �̸������� ������ �� �־ ���� ����� �� �ִ�.
        
        // 2. ���ҽ�(�޸�) ����
        // Ŭ������ ��ü�� ������ �ʿ䰡 �����Ƿ� �޸� ��뷮�� ���� �� �ִ�.
        // ��, �ݺ������� ���Ǵ� ��ƿ��Ƽ �Լ��� �־� ȿ�����̴�.

        // 3. ����(�Ӽ�) ������
        // �Ϲ������� ��ƿ��Ƽ �Լ��� �Ӽ�(����)�� ������ �ʿ䰡 ����. ��ü�� ����� �������� �����Ƿ�
        // �Է¿� ���ؼ��� �����Ѵ�.
    }
}
