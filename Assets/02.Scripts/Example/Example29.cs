using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example29 : MonoBehaviour
{
    void Start()
    {
        int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7 };

        // arr �迭�� �ִ� ��� ���� for �ݺ����� �̿��ؼ� ����ϰ� �ʹ�.
        for (int i = 0; i < arr.Length; i++)
        {
            Debug.Log(arr[i]);
        }

        // foreach �ݺ���
        /**
        foreach(�ڷ��� ������ in �迭)
        {
            // ������ ����ϴ� �ڵ�
        }
         **/

        // foreach : �ε����� �ݺ� Ƚ�� �Ű� �� �ʿ� ���� �迭�� ��� ��ҿ� ������ �� �ִ�.
        // ���� �о�ͼ� num �� �ִ� ��
        // ���� : �ڵ尡 �پ���. -> ������ ���
        // ���� : ������ �� �� ����. �� ����� ���� ������ �� ����.

        int index = 0;
        foreach (int num in arr)
        {
            Debug.Log(index);
            Debug.Log(num);
            index++;
        }      
    }
}
