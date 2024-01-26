using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyStudent
{
    // static(����) -> Ŭ������ ��ü�� �ƴ� Ŭ���� ��ü�� �Ҽ�
    // Ŭ������ �����ϰ� ��ü�� �����Ͽ� ��ü�� ���(����, �޼ҵ�)�� �����ϴ�
    // ���� ��İ� �ٸ��� ��ü�� �������� �ʰ� Ŭ���� ��ü���� ����� ����� �� �ִ�.
    // �� �ٸ� �̸��� '����'��.
    private static int Number; // ���� ����
    // �ܺο��� ���� �ٲ��� ���ϰ� ���� ������ private

    public string Name;
    public int Age; // ���� ����

    public MyStudent(string name, int age)
    {
        this.Name = name;
        Age = age;

        Number++;
    }

    // �޼ҵ� ��ȯ �ڷ��� �տ� 'static' Ű���� ���
    // ���� �޼ҵ�� ��ü�� ������� Ŭ���� �̸����� �ٷ� ȣ���� �� �ִ�.
    public static void Hello()
    {
        Debug.Log("Hello");

        // ���� �޼ҵ� ���ο����� ����� ������ �� ����. (������ �� ����.)
        // (Ŭ������ ���������Ƿ� Ŭ������ ��ü/����ʹ� ������ ����.)
        // Debug.Log($"�ȳ�, �� �̸��� {Name}�̾�."); -> ����      
    }

    // Number�� �ܺο��� ����ϱ� ���� �Լ�
    public static int GetNumber()
    {
        return Number;
    }
}
