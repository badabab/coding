using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example11 : MonoBehaviour
{
    //���ӿ��� ĳ���͸� ������� �� �� ĳ������ ������ ���ȭ�ؼ� ����
    const int PlayerIdle = 0;
    const int PlayerMove = 1;
    const int PlayerAttack = 2;
    const int PlayerDeath = 3;

    public int PlayerCurrentState = PlayerIdle;

    // ������(enum) : ����� �ϳ��� �׷����� ��� �����ϴ� ���
    public enum PlayerStates
    {
        Idle,
        Move,
        Attack,
        Death,
    }

    public PlayerStates State = PlayerStates.Idle;

    
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
