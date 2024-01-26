using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test38 : MonoBehaviour
{
    public string S = "baekjoon";

    void Start()
    {
        int[] alphabet = new int[26]; // ���ĺ� ���� 26��

        for (int i = 0; i < alphabet.Length; i++)
        {
            alphabet[i] = -1;
        }

        // ���ĺ��� ù ���� ��ġ
        for (int i = 0; i < S.Length; i++)
        {
            char word = S[i];
            int num = word - 97;  // a~z �ƽ�Ű�ڵ� : 97~122, num�� 0���� �Է�

            if (alphabet[num] == -1)
            {
                alphabet[num] = i;
            }
        }

        for (int i = 0; i < alphabet.Length; i++)
        {
            if (alphabet[i] != -1)
            {
                Debug.Log(alphabet[i]);
            }
            else
            {
                Debug.Log(-1);
            }
        }
    }
}
