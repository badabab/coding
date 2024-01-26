using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 상속 : 유산 상속처럼 부모(기반 클래스)가 자식(파생 클래스)에게 속성과 행동을 물려준다.
// 공통적인 부분을 가지고 있는 상위 클래스를 활용해서 하위 클래스에서 중복을 줄여준다. -> 코드 간결/이해력 up
public class Cat : Animal
{
    // 속성(멤버 변수)
    public bool LikeWater;

    // 생성자
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

    // 메소드 오버라이딩
    // 부모 클래스의 메소드가 아닌 자식 클래스의 메소드가 호출되도록 하는 것
    // 부모 클래스에서는 virtual 키워드와 함께 메소드를 정의하고
    // 자식 클래스에서는 override 키워드와 함께 재정의한다.

    public override void Sleep()
    {
        Debug.Log($"{Name} : 웅크려서 잡니다.");
    }
    public override void Run()
    {
        Debug.Log($"{Name} : 사뿐사뿐 뜁니다.");
    }

    // 행동 (멤버함수 = 메서드)
    public void Meow()
    {
        Debug.Log($"{Name} : 야옹");
    }
    public void Grooming(Cat otherCat)
    {
        Debug.Log($"{Name}이 {otherCat.Name}를 그루밍한다.");
    }
    public void Grooming(Dog otherDog)
    {
        Debug.Log($"{Name}이 {otherDog.Name}를 그루밍한다.");
    }
    public void Print()
    {
        Debug.Log($"이름:{Name} 나이:{Age} 털 색깔:{Color} 종:{Species} 무게:{Weight} 수속성?:{LikeWater}");
    }
}
