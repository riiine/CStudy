using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewDataType : MonoBehaviour
{
    enum Week // �츮�� ���� ���� �������� ��Ÿ�� �ڷ��� (������)
    {
        Mon,
        Tue,
        Wed,
        Thu,
        Fri,
        Sat,
        Sun
    }

    // ���� ���� �ڷ������� ���� ����
    Week week = Week.Mon;

    enum State // ĳ������ ����
    {
        Idle,
        Walk,
        Run,
        Attack,
        Sleep
    }


    // Start is called before the first frame update
    void Start()
    {
        week = Week.Fri;

        State state = State.Sleep;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
