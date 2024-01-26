using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test00 : MonoBehaviour
{
    public string InputString = "ljes=njak";
    void Start()
    {
        string[] Croatia = { "c=", "c-", "dz=", "d-", "lj", "nj", "s=", "z=" };
        int count = 0;

        for (int i = 0; i < InputString.Length; i++)
        {
            foreach (string word in Croatia)
            {
                // 현재 위치 i에서부터 각 문자가 일치하는지 확인
                for (int j = 0; j < word.Length; j++)
                {
                    // 현재 위치가 InputString의 길이를 초과하거나, 문자가 일치하지 않는 경우
                    if (i + j >= InputString.Length || InputString[i + j] != word[j])
                    {
                        break;
                    }

                    // 현재 단어의 마지막 문자까지 일치하는 경우
                    if (j == word.Length - 1)
                    {
                        count++;
                        // 현재 위치 i를 패턴의 길이만큼 뒤로 이동
                        i += word.Length - 1;
                        count -= word.Length; // 크로아티아 글자의 길이를 빼줍니다.
                        break;
                    }
                }
            }
            // 크로아티아 알파벳이 아닌 경우
            count++;
        }
        Debug.Log(count);
    }
}
