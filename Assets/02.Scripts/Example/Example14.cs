using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Example14 : MonoBehaviour
{
    void Start()
    {
        // 5. �� ������
        // ������ ���ϴ� �� �����ڰ� ���ÿ� �� �� �̻� ����� �� ����Ѵ�.
        // ����� true, false

        // && (AND) : �׸���, �� ������ ��� ���� ���� ��
        // || (OR) : �Ǵ�, �� ���� �� �ϳ��� ���̾ ��
        // ! (NOT) : ���� ��������, ������ ������ �ٲ��ִ� ������

        int num1 = 40;
        int num2 = 30;
        int num3 = 20;

        // AND
        bool result1 = num1 > num2 && num2 > num3;
        //                true     &&     true           -> result1 : true

        int hour = 14;
        // 00�н����� ���� �ð� 10�ú��� 20�ñ��� �Դϴ�.
        bool isOpen = (10 <= hour) && (hour <= 20);

        // OR
        bool result2 = num1 > num2 || num2 < num3;
        //                true     ||     false          -> result2 : true

        // 00�н����� ���� �ð��� 15�� �Ǵ� 19�� �Դϴ�.
        bool isDiscardTime = (hour == 15) || (hour == 19);

        // NOT
        //bool result3 = !true; // false 


        int a = 10;
        int b = 20;

        // ������ �켱����
        // �����ڸ��� �켱������ ������ �ִ�.
        // ��ȣ �ȿ� �ִ� �����ڰ� ���� ���� ���ǹǷ� �򰥸��� ��ȣ�� ��������.

        bool example = (((a++) * 5) + 2) > (++b + 1 * 3 / 2);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
