using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 추상 클래스 : 구체적이지 않은 추상적인 데이터와 메소드를 담고 있는 클래스
// new 연산자를 이용해 객체를 생성할 수 없는 클래스
// 추상 클래스는 공통적으로 이런 데이터들이 있다. 이런 메소드를 구현해야 한다 등
// 자식 클래스에게 구현을 강제하도록 하는 클래스
public abstract class Animal : MonoBehaviour
{
    
    // 속성(멤버 변수)
    public string Name;         // 이름
    public int Age;             // 나이
    public string Color;        // 털 색깔
    public string Species;      // 종
    protected float Weight;        // 무게

    // 행동(메서드)
    public abstract void Run();
    // 추상 메소드 : 구현 내용이 없고, "이런 메소드를 사용할 것이다", "이런 메소드를 구현해야 한다."
    // 라고 자식 클래스에게 구현을 강제하도록 한다.
    // (선언만 하고 구현부가 없다. 세미콜론(;)으로 끝나야 한다.)

    public virtual void Sleep()
    {
        Debug.Log($"{Name} : 잠자기");
    }
}
