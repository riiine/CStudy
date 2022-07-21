using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAnswer : MonoBehaviour
{
    public string m_UserSelect; // 사용자 선택
    public string m_ComSelect; // 컴퓨터 선택
    int m_UserScore = 0; // 사용자의 스코어 저장
    int m_ComScore = 0; // 컴퓨터의 스코어 저장
    int m_win = 0; // 승리수

    int gameCount = 0; // 게임 진행 횟수

    public bool isEnd; // 게임종료 판단

    // Start is called before the first frame update
    void Start()
    {
        // 시작하자마자 "가위, 바위, 보 중 하나를 입력하세요" 출력
        // 인스펙터 창에서 보이는 변수(m_UserSelect)에 가위, 바위, 보 중 하나를 입력
        print("묵찌빠를 시작하기 전, 가위, 바위, 보 중 하나를 입력하세요.");
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Return))
        {
            // 0 : 가위, 1 : 바위, 2 : 보
            // 엔터키를 누르면 컴퓨터도 가위, 바위, 보 중 하나를 랜덤으로 선택
            int random = Random.Range(0, 3);

            while (true)
            {
                if (random == 0)
                {
                    m_ComSelect = "가위";

                    if (m_UserSelect == "가위") // 무승부
                    {
                        gameCount++;
                        print($"나 : {m_UserSelect} ,컴퓨터 : {m_ComSelect}, 결과 : 무승부");
                    }
                    if (m_UserSelect == "바위")
                    {
                        gameCount++;
                        m_UserScore++; // 유저가 이겼으므로 유저 스코어 증가
                        m_win++; // 승리수 증가
                        print($"나 : {m_UserSelect} ,컴퓨터 : {m_ComSelect}, 결과 : 유저 승리");
                        break;
                    }
                    if (m_UserSelect == "보")
                    {
                        gameCount++;
                        m_ComScore++; // 컴퓨터가 이겼으므로 컴퓨터 스코어 증가
                        print($"나 : {m_UserSelect} ,컴퓨터 : {m_ComSelect}, 결과 : 컴퓨터 승리");
                    }
                }
                if (random == 1)
                {
                    m_ComSelect = "바위";

                    if (m_UserSelect == "가위")
                    {
                        gameCount++;
                        m_UserScore++; // 유저가 이겼으므로 유저 스코어 증가
                        m_win++; // 승리수 증가
                        print($"나 : {m_UserSelect} ,컴퓨터 : {m_ComSelect}, 결과 : 유저 승리");
                        break;
                    }
                    if (m_UserSelect == "바위") // 무승부
                    {
                        gameCount++;
                        print($"나 : {m_UserSelect} ,컴퓨터 : {m_ComSelect}, 결과 : 무승부");
                    }
                    if (m_UserSelect == "보")
                    {
                        gameCount++;
                        m_ComScore++; // 컴퓨터가 이겼으므로 컴퓨터 스코어 증가
                        print($"나 : {m_UserSelect} ,컴퓨터 : {m_ComSelect}, 결과 : 컴퓨터 승리");
                    }
                }
                if (random == 2)
                {
                    m_ComSelect = "보";

                    if (m_UserSelect == "가위")
                    {
                        gameCount++;
                        m_UserScore++; // 유저가 이겼으므로 유저 스코어 증가
                        m_win++; // 승리수 증가
                        print($"나 : {m_UserSelect} ,컴퓨터 : {m_ComSelect}, 결과 : 유저 승리");
                        break;
                    }
                    if (m_UserSelect == "바위")
                    {
                        gameCount++;
                        m_ComScore++; // 컴퓨터가 이겼으므로 컴퓨터 스코어 증가
                        print($"나 : {m_UserSelect} ,컴퓨터 : {m_ComSelect}, 결과 : 컴퓨터 승리");
                    }
                    if (m_UserSelect == "보") // 무승부
                    {
                        gameCount++;
                        print($"나 : {m_UserSelect} ,컴퓨터 : {m_ComSelect}, 결과 : 무승부");
                    }

                }
                continue;
            }    
            
        }

        while (true)
        {
            if (m_win == 1) // 내가 공격일 때
            {
                print("나 : 공격, 컴퓨터 : 수비 입니다. 묵, 찌, 빠 중 하나를 입력하세요.");

                if (Input.GetKeyDown(KeyCode.Return))
                {
                    // 0 : 묵, 1 : 찌, 2 : 빠
                    // 엔터키를 누르면 컴퓨터도 묵, 찌, 빠 중 하나를 랜덤으로 선택
                    int random = Random.Range(0, 3);

                    if (random == 0)
                    {
                        m_ComSelect = "묵";

                        if (m_UserSelect == "묵")
                        {
                            gameCount++;
                            print($"나 : {m_UserSelect} ,컴퓨터 : {m_ComSelect}, 결과 : 유저 승리");
                            m_UserScore++; // 유저가 이겼으므로 유저 스코어 증가
                            break;
                        }
                        if (m_UserSelect == "찌")
                        {
                            gameCount++;
                            print($"나 : {m_UserSelect} ,컴퓨터 : {m_ComSelect}, 결과 : 공수교대");
                            m_win = 2; // 공수교대하여 유저는 수비가 됨
                            continue;
                        }
                        if (m_UserSelect == "빠")
                        {
                            gameCount++;
                            print($"나 : {m_UserSelect} ,컴퓨터 : {m_ComSelect}, 결과 : 이어서");
                            continue;
                        }
                    }
                    if (random == 1)
                    {
                        m_ComSelect = "찌";

                        if (m_UserSelect == "묵")
                        {
                            gameCount++;
                            print($"나 : {m_UserSelect} ,컴퓨터 : {m_ComSelect}, 결과 : 이어서");
                            continue;
                        }
                        if (m_UserSelect == "찌") // 유저가 이겼으므로 유저 스코어 증가
                        {
                            gameCount++;
                            print($"나 : {m_UserSelect} ,컴퓨터 : {m_ComSelect}, 결과 : 유저 승리");
                            m_UserScore++; // 유저가 이겼으므로 유저 스코어 증가
                            break;
                        }
                        if (m_UserSelect == "빠")
                        {
                            gameCount++;
                            print($"나 : {m_UserSelect} ,컴퓨터 : {m_ComSelect}, 결과 : 공수교대");
                            m_win = 2; // 공수교대하여 유저는 수비가 됨
                            continue;
                        }
                    }
                    if (random == 2)
                    {
                        m_ComSelect = "빠";

                        if (m_UserSelect == "묵")
                        {
                            gameCount++;
                            print($"나 : {m_UserSelect} ,컴퓨터 : {m_ComSelect}, 결과 : 공수교대");
                            m_win = 2; // 공수교대하여 유저는 수비가 됨
                            continue;
                        }
                        if (m_UserSelect == "찌")
                        {
                            gameCount++;
                            print($"나 : {m_UserSelect} ,컴퓨터 : {m_ComSelect}, 결과 : 이어서");
                            continue;
                        }
                        if (m_UserSelect == "빠")
                        {
                            gameCount++;
                            print($"나 : {m_UserSelect} ,컴퓨터 : {m_ComSelect}, 결과 : 유저 승리");
                            m_UserScore++; // 유저가 이겼으므로 유저 스코어 증가
                            break;
                        }
                    }

                }
            }

            if (m_win == 2) // 내가 수비일 때
            {
                print("나 : 수비, 컴퓨터 : 공격 입니다. 묵, 찌, 빠 중 하나를 입력하세요.");

                if (Input.GetKeyDown(KeyCode.Return))
                {
                    // 0 : 묵, 1 : 찌, 2 : 빠
                    // 엔터키를 누르면 컴퓨터도 묵, 찌, 빠 중 하나를 랜덤으로 선택
                    int random = Random.Range(0, 3);

                    if (random == 0)
                    {
                        m_ComSelect = "묵";

                        if (m_UserSelect == "묵")
                        {
                            gameCount++;
                            print($"나 : {m_UserSelect} ,컴퓨터 : {m_ComSelect}, 결과 : 컴퓨터 승리");
                            m_ComScore++; // 컴퓨터가 이겼으므로 컴퓨터 스코어 증가
                            break;
                        }
                        if (m_UserSelect == "찌")
                        {
                            gameCount++;
                            print($"나 : {m_UserSelect} ,컴퓨터 : {m_ComSelect}, 결과 : 이어서");
                            continue;
                        }
                        if (m_UserSelect == "빠")
                        {
                            gameCount++;
                            print($"나 : {m_UserSelect} ,컴퓨터 : {m_ComSelect}, 결과 : 공수교대");
                            m_win = 1; // 공수교대하여 유저는 공격이 됨
                            continue;
                        }
                    }
                    if (random == 1)
                    {
                        m_ComSelect = "찌";

                        if (m_UserSelect == "묵")
                        {
                            gameCount++;
                            print($"나 : {m_UserSelect} ,컴퓨터 : {m_ComSelect}, 결과 : 공수교대");
                            m_win = 1; // 공수교대하여 유저는 공격이 됨
                            continue;
                        }
                        if (m_UserSelect == "찌")
                        {
                            gameCount++;
                            print($"나 : {m_UserSelect} ,컴퓨터 : {m_ComSelect}, 결과 : 컴퓨터 승리");
                            m_ComScore++; // 컴퓨터가 이겼으므로 컴퓨터 스코어 증가
                            break;
                        }
                        if (m_UserSelect == "빠")
                        {
                            gameCount++;
                            print($"나 : {m_UserSelect} ,컴퓨터 : {m_ComSelect}, 결과 : 이어서");
                            continue;
                        }
                    }
                    if (random == 2)
                    {
                        m_ComSelect = "빠";

                        if (m_UserSelect == "묵")
                        {
                            gameCount++;
                            print($"나 : {m_UserSelect} ,컴퓨터 : {m_ComSelect}, 결과 : 이어서");
                            continue;
                        }
                        if (m_UserSelect == "찌")
                        {
                            gameCount++;
                            print($"나 : {m_UserSelect} ,컴퓨터 : {m_ComSelect}, 결과 : 공수교대");
                            m_win = 1; // 공수교대하여 유저는 공격이 됨
                            continue;
                        }
                        if (m_UserSelect == "빠")
                        {
                            gameCount++;
                            print($"나 : {m_UserSelect} ,컴퓨터 : {m_ComSelect}, 결과 : 유저 승리");
                            m_ComScore++; // 컴퓨터가 이겼으므로 컴퓨터 스코어 증가
                            print($"게임종료!! 나 : {m_UserSelect} ,컴퓨터 : {m_ComSelect}, 게임진행횟수 : {gameCount}, 현재 스코어 : {m_UserScore} : {m_ComScore}");
                            break;
                        }
                    }

                }
            }
            return;
        }


    }

}
