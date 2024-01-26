using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �߻� Ŭ���� : ��ü������ ���� �߻����� �����Ϳ� �޼ҵ带 ��� �ִ� Ŭ����
// new �����ڸ� �̿��� ��ü�� ������ �� ���� Ŭ����
// �߻� Ŭ������ ���������� �̷� �����͵��� �ִ�. �̷� �޼ҵ带 �����ؾ� �Ѵ� ��
// �ڽ� Ŭ�������� ������ �����ϵ��� �ϴ� Ŭ����
public abstract class Animal : MonoBehaviour
{
    
    // �Ӽ�(��� ����)
    public string Name;         // �̸�
    public int Age;             // ����
    public string Color;        // �� ����
    public string Species;      // ��
    protected float Weight;        // ����

    // �ൿ(�޼���)
    public abstract void Run();
    // �߻� �޼ҵ� : ���� ������ ����, "�̷� �޼ҵ带 ����� ���̴�", "�̷� �޼ҵ带 �����ؾ� �Ѵ�."
    // ��� �ڽ� Ŭ�������� ������ �����ϵ��� �Ѵ�.
    // (���� �ϰ� �����ΰ� ����. �����ݷ�(;)���� ������ �Ѵ�.)

    public virtual void Sleep()
    {
        Debug.Log($"{Name} : ���ڱ�");
    }
}
