using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestWorld : MonoBehaviour
{
    void Start()
    {
        //Animal animal = new Animal();

        // 다형성(Polymorphism) : 객체가 여러 개의 형태를 가지는 것
        Animal cat1 = new Cat("냥1", 5, "흰색", "페르시안", 5f, true);
        // 업캐스팅 : 하위클래스(Cat)을 상위클래스(Animal)로 형변환
        Cat cat2 = new Cat("냥2", 3, "회색", "벵골", 4.5f, false);

        Animal dog1 = new Dog("멍1", 7, "흰색", "시추", 5.5f, true);
        Dog dog2 = new Dog("멍2", 4, "검정색", "닥스훈트", 3.5f, false);

        // 형변환
        int a = 3;
        float b = (float)a;

        // 다운캐스팅 : 상위클래스(Animal)를 하위클래스(Cat or Dog)로 형변환
        Cat newCat = (Cat)cat1;
        newCat.Meow();
        cat2.Meow();

        // Cat newCat2 = (Cat)dog1;
        // newCat2.Meow();
        // 잘못된 다운 캐스팅은 컴파일 단계에서 오류가 발생하지 않고, 런타임 단계에서 오류가 일어난다.
        // 그래서 런타임 단계에서 형변환이 가능한지 또는 형변환이 성공했는지 확인하는
        // 'is'와 'as' 연산자가 있다.

        // is 연산자 : 객체가 해당 타입이 맞는지 검사한 후 그 결과를 bool 값으로 변환
        if (dog1 is Cat)
        {
            newCat = (Cat)dog1;
            newCat.Meow();
        }
        else
        {
            Debug.Log("dog1은 고양이가 아닙니다.");
        }

        // as 연산자 : 형변환이 가능하면 형변환을 하고, 형변환에 실패하면 null을 반환한다.
        Dog dog3 = dog1 as Dog;
        if(dog3 == null)
        {
            Debug.Log("dog1은 강아지가 아닙니다.");
        }
        else
        {
            dog3.Bark();    // '멍1 : 멍멍' 출력
        }

        cat1.Run();
        cat2.Run();
        dog1.Run();
        dog2.Run();

        cat1.Sleep();
        cat2.Sleep();
        dog1.Sleep();
        dog2.Sleep();

       /* cat1.Meow();
        cat2.Meow();
        dog1.Bark();
        dog2.Bark();

        cat1.Grooming(cat2);
        cat1.Grooming(dog1);
        dog1.Bring(dog2);
        dog1.Bring(cat1);

        cat1.Print();
        cat2.Print();
        dog1.Print();
        dog2.Print();*/
    }
}
