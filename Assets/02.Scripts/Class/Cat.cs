using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ��� : ���� ���ó�� �θ�(��� Ŭ����)�� �ڽ�(�Ļ� Ŭ����)���� �Ӽ��� �ൿ�� �����ش�.
// �������� �κ��� ������ �ִ� ���� Ŭ������ Ȱ���ؼ� ���� Ŭ�������� �ߺ��� �ٿ��ش�. -> �ڵ� ����/���ط� up
public class Cat : Animal
{
    // �Ӽ�(��� ����)
    public bool LikeWater;

    // ������
    public Cat()
    {

    }
    public Cat(string name, int age, string color, string species, float weight, bool likeWater)
    {
        Name = name;
        Age = age;
        Color = color;
        Species = species;
        Weight = weight;
        LikeWater = likeWater;
    }

    // �޼ҵ� �������̵�
    // �θ� Ŭ������ �޼ҵ尡 �ƴ� �ڽ� Ŭ������ �޼ҵ尡 ȣ��ǵ��� �ϴ� ��
    // �θ� Ŭ���������� virtual Ű����� �Բ� �޼ҵ带 �����ϰ�
    // �ڽ� Ŭ���������� override Ű����� �Բ� �������Ѵ�.

    public override void Sleep()
    {
        Debug.Log($"{Name} : ��ũ���� ��ϴ�.");
    }
    public override void Run()
    {
        Debug.Log($"{Name} : ��ӻ�� �ݴϴ�.");
    }

    // �ൿ (����Լ� = �޼���)
    public void Meow()
    {
        Debug.Log($"{Name} : �߿�");
    }
    public void Grooming(Cat otherCat)
    {
        Debug.Log($"{Name}�� {otherCat.Name}�� �׷���Ѵ�.");
    }
    public void Grooming(Dog otherDog)
    {
        Debug.Log($"{Name}�� {otherDog.Name}�� �׷���Ѵ�.");
    }
    public void Print()
    {
        Debug.Log($"�̸�:{Name} ����:{Age} �� ����:{Color} ��:{Species} ����:{Weight} ���Ӽ�?:{LikeWater}");
    }
}
