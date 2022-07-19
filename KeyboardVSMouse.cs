using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardVSMouse : MonoBehaviour
{
    // 마우스 클릭 횟수
    public int mouseCount;

    // 키보드 클릭 횟수
    public int keyboardCount = 0;

    // 결과 저장할 변수
    string result = "";

    // 게임이 끝났는지
    public bool isEnd;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 0 : 좌클릭, 1 : 우클릭, 2 : 휠클릭

        //// 좌클릭을 하고 있는 중
        //if (Input.GetMouseButton(0))
        //{
        //    print("좌클릭 하는 중");
        //}

        //// 좌클릭 뗐을 때
        //if (Input.GetMouseButtonUp(2))
        //{
        //    print("좌클릭 뗐을 때");
        //}

        // 게임이 종료됐다면
        if (isEnd)
        {
            return;
        }

        // 좌클릭을 한 순간
        if (Input.GetMouseButtonDown(0))
        {
            // 마우스 클릭 횟수 증가
            mouseCount++;
        }

        // 스페이바를 누른 순간
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // 키보드 누른 횟수 증가
            keyboardCount++;
        }

        // 둘 중에 하나라도 10이 되면
        if (mouseCount == 10 || keyboardCount == 10)
        {
            // 게임 종료
            isEnd = true;

            // 마우스가 이겼다면
            if (mouseCount > keyboardCount)
            {
                result = "마우스 승";
            }
            // 키보드가 이겼다면
            else if (mouseCount < keyboardCount)
            {
                result = "키보드 승";
            }
            // 무승부
            else
            {
                result = "무승부";
            }

            // 게임 종료! 마우스 : 0점, 키보드 : 0점, 결과 : ~
            //print("게임 종료! 마우스 : " + mouseCount + "점, "
            //    + "키보드 : " + keyboardCount + "점, 결과 : " + result);
            print($"게임 종료! 마우스 : {mouseCount}점, 키보드 : {keyboardCount}점, 결과 : {result}");
        }
    }
}
