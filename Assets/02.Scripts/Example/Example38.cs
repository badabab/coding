using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example38 : MonoBehaviour
{
    // ���� ���� �Ű� ����
    // -> �Ű� ���� ������ �����ϰ� ���Ѵ�.
    int Add(params int[] nums)
    {
        int sum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }
        return sum;
    }

    void Start()
    {
        Debug.Log(Add(1, 2, 3, 4, 5, 6, 7, 8, 9));
        
    }
}
