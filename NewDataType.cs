using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewDataType : MonoBehaviour
{
    enum Week // 우리가 새로 만든 일주일을 나타낼 자료형 (열거형)
    {
        Mon,
        Tue,
        Wed,
        Thu,
        Fri,
        Sat,
        Sun
    }

    // 새로 만든 자료형으로 만든 변수
    Week week = Week.Mon;

    enum State // 캐릭터의 상태
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
