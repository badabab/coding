using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    // �Ӽ�(��� ����)
    public bool Walk;

    // ������
    public Dog()
    {

    }
    public Dog (string name, int age, string color, string species, float weight, bool walk)
    {
        Name = name;
        Age = age;
        Color = color;
        Species = species;
        Weight = weight;
        Walk = walk;
    }

    public override void Sleep()
    {
        Debug.Log($"{Name} : ��ó�� ��ϴ�.");
    }
    public override void Run()
    {
        Debug.Log($"{Name} : ��ó�� �ݴϴ�.");
    }

    // �޼���

    public void Bark()
    {
        Debug.Log($"{Name} : �۸�");
    }

    public void Bring(Dog otherDog)
    {
        Debug.Log($"{Name}�� {otherDog.Name}�� ����´�.");
    }
    public void Bring(Cat otherCat)
    {
        Debug.Log($"{Name}�� {otherCat.Name}�� ����´�.");
    }
    public void Print()
    {
        Debug.Log($"�̸�:{Name} ����:{Age} �� ����:{Color} ��:{Species} ����:{Weight} ��å?:{Walk}");
    }
}
