using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockScissorPaper : MonoBehaviour
{
    public string m_UserSelect; // 사용자 선택
    public string m_ComSelect; // 컴퓨터 선택
    int m_UserScore = 0; // 사용자의 스코어 저장
    int m_ComScore = 0; // 컴퓨터의 스코어 저장

    int gameCount = 0; // 게임 진행 횟수

    string result = ""; // 결과

    public bool isEnd; // 게임종료 판단

    // Start is called before the first frame update
    void Start()
    {
        // 시작하자마자 "가위, 바위, 보 중 하나를 입력하세요" 출력
        // 인스펙터 창에서 보이는 변수(m_UserSelect)에 가위, 바위, 보 중 하나를 입력
        print("가위, 바위, 보 중 하나를 입력하세요.");
    }

    // Update is called once per frame
    void Update()
    {
        // 게임이 종료됐다면
        if (isEnd)
        {
            return;
        }

        if (gameCount < 5) 
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                // 0 : 가위, 1 : 바위, 2 : 보
                // 엔터키를 누르면 컴퓨터도 가위, 바위, 보 중 하나를 랜덤으로 선택
                int random = Random.Range(0, 3);

                if (random == 0)
                {
                    m_ComSelect = "가위";

                    if (m_UserSelect == "가위") // 무승부
                    {
                        gameCount++;
                        print($"나 : {m_UserSelect} ,컴퓨터 : {m_ComSelect}, 결과 : 무승부, 현재 스코어 : {m_UserScore} : {m_ComScore}");
                    }
                    if (m_UserSelect == "바위")
                    {
                        gameCount++;
                        m_UserScore++; // 유저가 이겼으므로 유저 스코어 증가
                        print($"나 : {m_UserSelect} ,컴퓨터 : {m_ComSelect}, 결과 : 유저 승리, 현재 스코어 : {m_UserScore} : {m_ComScore}");
                    }
                    if (m_UserSelect == "보")
                    {
                        gameCount++;
                        m_ComScore++; // 컴퓨터가 이겼으므로 컴퓨터 스코어 증가
                        print($"나 : {m_UserSelect} ,컴퓨터 : {m_ComSelect}, 결과 : 컴퓨터 승리, 현재 스코어 : {m_UserScore} : {m_ComScore}");
                    }
                }
                if (random == 1)
                {
                    m_ComSelect = "바위";

                    if (m_UserSelect == "가위")
                    {
                        gameCount++;
                        m_UserScore++; // 유저가 이겼으므로 유저 스코어 증가
                        print($"나 : {m_UserSelect} ,컴퓨터 : {m_ComSelect}, 결과 : 유저 승리, 현재 스코어 : {m_UserScore} : {m_ComScore}");
                    }
                    if (m_UserSelect == "바위") // 무승부
                    {
                        gameCount++;
                        print($"나 : {m_UserSelect} ,컴퓨터 : {m_ComSelect}, 결과 : 무승부, 현재 스코어 : {m_UserScore} : {m_ComScore}");
                    }
                    if (m_UserSelect == "보")
                    {
                        gameCount++;
                        m_ComScore++; // 컴퓨터가 이겼으므로 컴퓨터 스코어 증가
                        print($"나 : {m_UserSelect} ,컴퓨터 : {m_ComSelect}, 결과 : 컴퓨터 승리, 현재 스코어 : {m_UserScore} : {m_ComScore}");
                    }
                }
                if (random == 2)
                {
                    m_ComSelect = "보";

                    if (m_UserSelect == "가위")
                    {
                        gameCount++;
                        m_UserScore++; // 유저가 이겼으므로 유저 스코어 증가
                        print($"나 : {m_UserSelect} ,컴퓨터 : {m_ComSelect}, 결과 : 유저 승리, 현재 스코어 : {m_UserScore} : {m_ComScore}");
                    }
                    if (m_UserSelect == "바위")
                    {
                        gameCount++;
                        m_ComScore++; // 컴퓨터가 이겼으므로 컴퓨터 스코어 증가
                        print($"나 : {m_UserSelect} ,컴퓨터 : {m_ComSelect}, 결과 : 컴퓨터 승리, 현재 스코어 : {m_UserScore} : {m_ComScore}");
                    }
                    if (m_UserSelect == "보") // 무승부
                    {
                        gameCount++;
                        print($"나 : {m_UserSelect} ,컴퓨터 : {m_ComSelect}, 결과 : 무승부, 현재 스코어 : {m_UserScore} : {m_ComScore}");
                    }
                }

            }
        }

        if (gameCount == 5) // 5판이 진행되면
        {
            // 게임 종료
            isEnd = true;

            if (m_UserScore > m_ComScore) 
            {
                result = "유저 승리";
            }
            if (m_UserScore < m_ComScore)
            {
                result = "컴퓨터 승리";
            }
            if (m_UserScore == m_ComScore)
            {
                result = "무승부";
            }

            print($"게임종료!! 나 : {m_UserSelect} ,컴퓨터 : {m_ComSelect}, 결과 : {result}, 현재 스코어 : {m_UserScore} : {m_ComScore}");
        }

    }
    
}
