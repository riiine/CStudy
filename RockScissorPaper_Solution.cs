/** 강사님 답 */



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockScissorPaper_Solution : MonoBehaviour
{
    // 2-1. 플레이어가 선택
    public string myChoice;

    // 2-2. 컴퓨터가 선택
    string comChoice;

    // 2-5. 각 판의 결과
    string result;

    // 2-7. 스코어
    int myScore, comScore;

    // 3-1. 게임 횟수
    int gameCount;

    // Start is called before the first frame update
    void Start()
    {
        // 1. 시작 멘트
        print("가위, 바위, 보 중 하나를 입력하세요.");
    }

    // Update is called once per frame
    void Update()
    {
        // 3-4. 게임을 5판 했다면 더 이상 진행 X
        if(gameCount >= 5)
        {
            return;
        }

        // 2-3. 엔터키를 누르면
        if(Input.GetKeyDown(KeyCode.Return))
        {
            // 2-4. 컴퓨터도 셋 중 하나 선택
            int rand = Random.Range(0, 3);
            switch(rand)
            {
                case 0: comChoice = "가위"; break;
                case 1: comChoice = "바위"; break;
                case 2: comChoice = "보"; break;
            }

            // 2-6. 내가 낸 것과 컴퓨터가 낸 것에 따라 결과 다르게
            switch(myChoice)
            {
                case "가위": 
                    switch(comChoice)
                    {
                        case "가위":  result = "무승부"; break;
                        case "바위": result = "컴퓨터 승"; comScore++; break;
                        case "보": result = "플레이어 승"; myScore++;  break;
                    }
                    break;

                case "바위":
                    switch (comChoice)
                    {
                        case "가위": result = "플레이어 승"; myScore++; break;
                        case "바위": result = "무승부"; break;
                        case "보": result = "컴퓨터 승"; comScore++; break;
                    }
                    break;

                case "보":
                    switch (comChoice)
                    {
                        case "가위": result = "컴퓨터 승"; comScore++; break;
                        case "바위": result = "플레이어"; myScore++; break;
                        case "보": result = "무승부"; break;
                    }
                    break;
            }

            // 2-8. 한 판당 결과 한 줄 출력
            print($"플레이어 : {myChoice}, 컴퓨터 : {comChoice}" +
                $" {result}, 스코어(플레이어:컴퓨터) {myScore} : {comScore}");

            // 3-2. 게임 횟수 증가
            gameCount++;

            // 3-3. 게임을 5판 했다면
            if (gameCount == 5)
            {
                // 3-5. 스코어에 따라 최종 결과 한 줄로 출력
                if(myScore > comScore)
                {
                    print($"게임 끝! 플레이어 : 컴퓨터 = {myScore} : {comScore}, 플레이어 승");
                }
                else if(myScore < comScore)
                {
                    print($"게임 끝! 플레이어 : 컴퓨터 = {myScore} : {comScore}, 컴퓨터 승");
                }
                else
                {
                    print($"게임 끝! 플레이어 : 컴퓨터 = {myScore} : {comScore}, 무승부");
                }
            }
        }
    }
}
