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
                // ���� ��ġ i�������� �� ���ڰ� ��ġ�ϴ��� Ȯ��
                for (int j = 0; j < word.Length; j++)
                {
                    // ���� ��ġ�� InputString�� ���̸� �ʰ��ϰų�, ���ڰ� ��ġ���� �ʴ� ���
                    if (i + j >= InputString.Length || InputString[i + j] != word[j])
                    {
                        break;
                    }

                    // ���� �ܾ��� ������ ���ڱ��� ��ġ�ϴ� ���
                    if (j == word.Length - 1)
                    {
                        count++;
                        // ���� ��ġ i�� ������ ���̸�ŭ �ڷ� �̵�
                        i += word.Length - 1;
                        count -= word.Length; // ũ�ξ�Ƽ�� ������ ���̸� ���ݴϴ�.
                        break;
                    }
                }
            }
            // ũ�ξ�Ƽ�� ���ĺ��� �ƴ� ���
            count++;
        }
        Debug.Log(count);
    }
}
