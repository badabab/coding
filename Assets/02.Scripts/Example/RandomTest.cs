using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTest : MonoBehaviour
{
    void Start()
    {
        // UnityEngine.Random Ŭ����: ���� ������ �����ִ� Ŭ����
        // ����: ���ǵ� ���� ������ �������� ����� ��(=������)

        UnityEngine.Random.InitState(13);   // ���� ������ ���� �õ尪
        Debug.Log(UnityEngine.Random.Range(0, 100));  // (������, �ְ� - 1)
        // Debug.Log(UnityEngine.Random.Range(0f, 100f));  // �Ǽ� ����
    }
}
