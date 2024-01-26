using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    // 속성(멤버 변수)
    public bool Walk;

    // 생성자
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
        Debug.Log($"{Name} : 개처럼 잡니다.");
    }
    public override void Run()
    {
        Debug.Log($"{Name} : 개처럼 뜁니다.");
    }

    // 메서드

    public void Bark()
    {
        Debug.Log($"{Name} : 멍멍");
    }

    public void Bring(Dog otherDog)
    {
        Debug.Log($"{Name}이 {otherDog.Name}를 물어온다.");
    }
    public void Bring(Cat otherCat)
    {
        Debug.Log($"{Name}이 {otherCat.Name}를 물어온다.");
    }
    public void Print()
    {
        Debug.Log($"이름:{Name} 나이:{Age} 털 색깔:{Color} 종:{Species} 무게:{Weight} 산책?:{Walk}");
    }
}
