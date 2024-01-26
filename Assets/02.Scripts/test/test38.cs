using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test38 : MonoBehaviour
{
    public string S = "baekjoon";

    void Start()
    {
        int[] alphabet = new int[26]; // 알파벳 개수 26개

        for (int i = 0; i < alphabet.Length; i++)
        {
            alphabet[i] = -1;
        }

        // 알파벳의 첫 등장 위치
        for (int i = 0; i < S.Length; i++)
        {
            char word = S[i];
            int num = word - 97;  // a~z 아스키코드 : 97~122, num은 0부터 입력

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
