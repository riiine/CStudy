using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TicTacToe : MonoBehaviour
{
    // 테이블 만들기
    string[,] table = new string[3, 3];

    // 턴제를 위한 변수
    bool isX;

    // Start is called before the first frame update
    void Start()
    {
        // 테이블에 # 넣기
        for (int i = 0; i < table.GetLength(0); i++)
        {
            for (int j = 0; j < table.GetLength(1); j++)
            {
                table[i, j] = "#";
            }
        }

        // 테이블 3x3으로 출력
        TablePrint();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Keypad7))
        {
            InputKeypad(0,0);
        }
        else if (Input.GetKeyDown(KeyCode.Keypad8))
        {
            InputKeypad(0, 1);
        }
        else if (Input.GetKeyDown(KeyCode.Keypad9))
        {
            InputKeypad(0, 2);
        }
        else if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            InputKeypad(1, 0);
        }
        else if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            InputKeypad(1, 1);
        }
        else if (Input.GetKeyDown(KeyCode.Keypad6))
        {
            InputKeypad(1, 2);
        }
        else if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            InputKeypad(2, 0);
        }
        else if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            InputKeypad(2, 1);
        }
        else if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            InputKeypad(2, 2);
        }
    }

    // 테이블 출력
    void TablePrint()
    {
        // 테이블 3x3으로 출력
        string result = "";

        for (int i = 0; i < table.GetLength(0); i++)
        {
            for (int j = 0; j < table.GetLength(1); j++)
            {
                // 예쁜 모양을 위해 띄어쓰기
                result += table[i, j] + " ";
            }

            // 줄바꿈
            result += "\n";
        }

        print(result);
    }

    // 키패드를 누르면 호출
    void InputKeypad(int i, int j)
    {
        // 빈 공간을 선택했을 때만
        if (table[i, j] == "#")
        {
            if (isX)
            {
                table[i, j] = "X";
            }
            else
            {
                table[i, j] = "0";
            }

            TablePrint();

            // 턴 바꾸기
            isX = !isX;

            // 체크
            Check();
        }
        else
        {
            print("다른 칸을 선택하세요.");
        }
    }

    void Check()
    {
        // 가로 3줄 검사
        for (int i = 0; i < 3; i++)
        {
            // #이 아니고, 세 가지가 전부 같다면
            if (table[i, 0] != "#" && table[i, 0] == table[i, 1] && table[i, 0] == table[i, 2])
            {
                print($"{table[i, 0]}의 승리");
                RestTable();
                return;
            }
        }

        // 세로 3줄 검사
        for (int i = 0; i < 3; i++)
        {
            // #이 아니고, 세 가지가 전부 같다면
            if (table[0, i] != "#" && table[0, i] == table[1, i] && table[0, i] == table[2, i])
            {
                print($"{table[0, i]}의 승리");
                RestTable();
                return;
            }
        }

        // 대각선 \ 검사
        if (table[0, 0] != "#" && table[0, 0] == table[1, 1] && table[1, 1] == table[2, 2])
        {
            print($"{table[0, 0]}의 승리");
            RestTable();
            return;
        }
        // 대각선 / 검사
        if (table[0, 2] != "#" && table[0, 2] == table[1, 1] && table[1, 1] == table[2, 0])
        {
            print($"{table[0, 2]}의 승리");
            RestTable();
            return;
        }

        // 가로, 세로, 대각선 연결이 안 됐고, 아직 무승부 아닐 때
        foreach (var item in table)
        {
            if (item == "#")
            {
                return;
            }
        }

        // 가로, 세로, 대각선 연결이 안 됐고, 무승부라면
        print("무승부");
        RestTable();
    }

    // 게임 끝, 초기화
    void RestTable()
    {
        print("다시 시작하세요.");

        // 테이블에 # 넣기
        for (int i = 0; i < table.GetLength(0); i++)
        {
            for (int j = 0; j < table.GetLength(1); j++)
            {
                table[i, j] = "#";
            }
        }

        TablePrint();

        // 턴 초기화
        isX = false;
    }
}
