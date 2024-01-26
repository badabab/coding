using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestWorld : MonoBehaviour
{
    void Start()
    {
        //Animal animal = new Animal();

        // ������(Polymorphism) : ��ü�� ���� ���� ���¸� ������ ��
        Animal cat1 = new Cat("��1", 5, "���", "�丣�þ�", 5f, true);
        // ��ĳ���� : ����Ŭ����(Cat)�� ����Ŭ����(Animal)�� ����ȯ
        Cat cat2 = new Cat("��2", 3, "ȸ��", "����", 4.5f, false);

        Animal dog1 = new Dog("��1", 7, "���", "����", 5.5f, true);
        Dog dog2 = new Dog("��2", 4, "������", "�ڽ���Ʈ", 3.5f, false);

        // ����ȯ
        int a = 3;
        float b = (float)a;

        // �ٿ�ĳ���� : ����Ŭ����(Animal)�� ����Ŭ����(Cat or Dog)�� ����ȯ
        Cat newCat = (Cat)cat1;
        newCat.Meow();
        cat2.Meow();

        // Cat newCat2 = (Cat)dog1;
        // newCat2.Meow();
        // �߸��� �ٿ� ĳ������ ������ �ܰ迡�� ������ �߻����� �ʰ�, ��Ÿ�� �ܰ迡�� ������ �Ͼ��.
        // �׷��� ��Ÿ�� �ܰ迡�� ����ȯ�� �������� �Ǵ� ����ȯ�� �����ߴ��� Ȯ���ϴ�
        // 'is'�� 'as' �����ڰ� �ִ�.

        // is ������ : ��ü�� �ش� Ÿ���� �´��� �˻��� �� �� ����� bool ������ ��ȯ
        if (dog1 is Cat)
        {
            newCat = (Cat)dog1;
            newCat.Meow();
        }
        else
        {
            Debug.Log("dog1�� ����̰� �ƴմϴ�.");
        }

        // as ������ : ����ȯ�� �����ϸ� ����ȯ�� �ϰ�, ����ȯ�� �����ϸ� null�� ��ȯ�Ѵ�.
        Dog dog3 = dog1 as Dog;
        if(dog3 == null)
        {
            Debug.Log("dog1�� �������� �ƴմϴ�.");
        }
        else
        {
            dog3.Bark();    // '��1 : �۸�' ���
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
