using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test33 : MonoBehaviour
{
    public string Words = "The Curious Case of Benjamin Button";
    void Start()
    {
        int count = 0;
        for (int i = 0; i < Words.Length; i++)
        {
            char word = Words[i];
            if (word == ' ')
            {
                count++;
            }        
        }
        // �ܾ��� ���� = ��ĭ �� + 1
        Debug.Log(count + 1);
    }
}
