using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InGame : MonoBehaviour
{
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;
    public Button button6;
    public Button button7;
    public Button button8;
    public Button button9;

    public Button[] btns;

    public TextMeshProUGUI button1_Text;
    public TextMeshProUGUI button2_Text;
    public TextMeshProUGUI button3_Text;
    public TextMeshProUGUI button4_Text;
    public TextMeshProUGUI button5_Text;
    public TextMeshProUGUI button6_Text;
    public TextMeshProUGUI button7_Text;
    public TextMeshProUGUI button8_Text;
    public TextMeshProUGUI button9_Text;

    public TextMeshProUGUI result_Text; // 결과 텍스트

    bool isComTurn; // 누구 차례인지



    // Start is called before the first frame update
    void Start()
    {
        Reset();

        if (button1 != null)
            button1.onClick.AddListener(Button1Func);
        //함수 포인터 대기 방식
        if (button2 != null)
            button2.onClick.AddListener(Button2Func);
        if (button3 != null)
            button3.onClick.AddListener(Button3Func);
        if (button4 != null)
            button4.onClick.AddListener(Button4Func);
        if (button5 != null)
            button5.onClick.AddListener(Button5Func);
        if (button6 != null)
            button6.onClick.AddListener(Button6Func);
        if (button7 != null)
            button7.onClick.AddListener(Button7Func);
        if (button8 != null)
            button8.onClick.AddListener(Button8Func);
        if (button9 != null)
            button9.onClick.AddListener(Button9Func);

    }

    // Update is called once per frame
    void Update()
    {

    }

    void Button1Func() // Button1 눌렀을 때 반응 함수
    {
        if (button1_Text.text == "#")
        {
            if (isComTurn == false) // 나의 차례라면
            {
                button1_Text.text = "O";

                isComTurn = !isComTurn; // 턴 바꾸기


            }
            else
            {
                button1_Text.text = "X";

                isComTurn = !isComTurn; // 턴 바꾸기

            }
            Check(); // 승부를 체크하는 함수
        }

    }

    void Button2Func() // Button2 눌렀을 때 반응 함수
    {
        if (button2_Text.text == "#")
        {
            if (isComTurn == false) // 나의 차례라면
            {
                button2_Text.text = "O";

                isComTurn = !isComTurn; // 턴 바꾸기


            }
            else
            {
                button2_Text.text = "X";

                isComTurn = !isComTurn; // 턴 바꾸기

            }
            Check(); // 승부를 체크하는 함수
        }
    }
    void Button3Func() // Button3 눌렀을 때 반응 함수
    {
        if (button3_Text.text == "#")
        {
            if (isComTurn == false) // 나의 차례라면
            {
                button3_Text.text = "O";

                isComTurn = !isComTurn; // 턴 바꾸기

            }
            else
            {
                button3_Text.text = "X";

                isComTurn = !isComTurn; // 턴 바꾸기


            }
            Check(); // 승부를 체크하는 함수
        }
    }
    void Button4Func() // Button4 눌렀을 때 반응 함수
    {
        if (button4_Text.text == "#")
        {
            if (isComTurn == false) // 나의 차례라면
            {
                button4_Text.text = "O";

                isComTurn = !isComTurn; // 턴 바꾸기


            }
            else
            {
                button4_Text.text = "X";

                isComTurn = !isComTurn; // 턴 바꾸기


            }
            Check(); // 승부를 체크하는 함수
        }
    }
    void Button5Func() // Button5 눌렀을 때 반응 함수
    {
        if (button5_Text.text == "#")
        {
            if (isComTurn == false) // 나의 차례라면
            {
                button5_Text.text = "O";

                isComTurn = !isComTurn; // 턴 바꾸기


            }
            else
            {
                button5_Text.text = "X";

                isComTurn = !isComTurn; // 턴 바꾸기

            }
            Check(); // 승부를 체크하는 함수
        }
    }
    void Button6Func() // Button6 눌렀을 때 반응 함수
    {
        if (button6_Text.text == "#")
        {
            if (isComTurn == false) // 나의 차례라면
            {
                button6_Text.text = "O";

                isComTurn = !isComTurn; // 턴 바꾸기


            }
            else
            {
                button6_Text.text = "X";

                isComTurn = !isComTurn; // 턴 바꾸기


            }
            Check(); // 승부를 체크하는 함수
        }
    }
    void Button7Func() // Button7 눌렀을 때 반응 함수
    {
        if (button7_Text.text == "#")
        {
            if (isComTurn == false) // 나의 차례라면
            {
                button7_Text.text = "O";

                isComTurn = !isComTurn; // 턴 바꾸기


            }
            else
            {
                button7_Text.text = "X";

                isComTurn = !isComTurn; // 턴 바꾸기


            }
            Check(); // 승부를 체크하는 함수
        }
    }
    void Button8Func() // Button8 눌렀을 때 반응 함수
    {
        if (button8_Text.text == "#")
        {
            if (isComTurn == false) // 나의 차례라면
            {
                button8_Text.text = "O";

                isComTurn = !isComTurn; // 턴 바꾸기


            }
            else
            {
                button8_Text.text = "X";

                isComTurn = !isComTurn; // 턴 바꾸기


            }
            Check(); // 승부를 체크하는 함수
        }
    }
    void Button9Func() // Button9 눌렀을 때 반응 함수
    {
        if (button9_Text.text == "#")
        {
            if (isComTurn == false) // 나의 차례라면
            {
                button9_Text.text = "O";

                isComTurn = !isComTurn; // 턴 바꾸기

            }
            else
            {
                button9_Text.text = "X";

                isComTurn = !isComTurn; // 턴 바꾸기


            }
            Check(); // 승부를 체크하는 함수
        }
    }

    void Check()
    {
        // 가로 3줄 검사
        if (button1_Text.text != "#" && button1_Text.text == button2_Text.text && button1_Text.text == button3_Text.text)
        {
            print("가로");
            if (button1_Text.text == "O")
            {
                result_Text.text = "Player win!!";
                Reset();
                return;
            }
            if (button1_Text.text == "X")
            {
                result_Text.text = "Computer win!!";
                Reset();
                return;
            }
        }
        else if (button4_Text.text != "#" && button4_Text.text == button5_Text.text && button4_Text.text == button6_Text.text)
        {
            if (button4_Text.text == "O")
            {
                result_Text.text = "Player win!!";
                Reset();
                return;
            }
            if (button4_Text.text == "X")
            {
                result_Text.text = "Computer win!!";
                Reset();
                return;
            }
        }
        else if (button7_Text.text != "#" && button7_Text.text == button8_Text.text && button7_Text.text == button9_Text.text)
        {
            if (button7_Text.text == "O")
            {
                result_Text.text = "Player win!!";
                Reset();
                return;
            }
            if (button7_Text.text == "X")
            {
                result_Text.text = "Computer win!!";
                Reset();
                return;
            }

        }
        // 세로 3줄 검사
        if (button1_Text.text != "#" && button1_Text.text == button4_Text.text && button1_Text.text == button7_Text.text)
        {
            if (button1_Text.text == "O")
            {
                result_Text.text = "Player win!!";
                Reset();
                return;
            }
            if (button1_Text.text == "X")
            {
                result_Text.text = "Computer win!!";
                Reset();
                return;
            }
        }
        else if (button2_Text.text != "#" && button2_Text.text == button5_Text.text && button2_Text.text == button8_Text.text)
        {
            if (button2_Text.text == "O")
            {
                result_Text.text = "Player win!!";
                Reset();
                return;
            }
            if (button2_Text.text == "X")
            {
                result_Text.text = "Computer win!!";
                Reset();
                return;
            }
        }
        else if (button3_Text.text != "#" && button3_Text.text == button6_Text.text && button3_Text.text == button9_Text.text)
        {
            if (button3_Text.text == "O")
            {
                result_Text.text = "Player win!!";
                Reset();
                return;
            }
            if (button3_Text.text == "X")
            {
                result_Text.text = "Computer win!!";
                Reset();
                return;
            }
        }

        // 대각선 \ 검사
        if (button1_Text.text != "#" && button1_Text.text == button5_Text.text && button1_Text.text == button9_Text.text)
        {
            if (button1_Text.text == "O")
            {
                result_Text.text = "Player win!!";
                Reset();
                return;
            }
            if (button1_Text.text == "X")
            {
                result_Text.text = "Computer win!!";
                Reset();
                return;
            }
        }

        // 대각선 / 검사
        if (button3_Text.text != "#" && button3_Text.text == button5_Text.text && button3_Text.text == button7_Text.text)
        {
            if (button3_Text.text == "O")
            {
                result_Text.text = "Player win!!";
                Reset();
                return;
            }
            if (button3_Text.text == "X")
            {
                result_Text.text = "Computer win!!";
                Reset();
                return;
            }
        }

        // 모든 칸이 아직 "#" 일 때
        if (button1_Text.text == "#" &&
        button2_Text.text == "#" &&
        button3_Text.text == "#" &&
        button4_Text.text == "#" &&
        button5_Text.text == "#" &&
        button6_Text.text == "#" &&
        button7_Text.text == "#" &&
        button8_Text.text == "#" &&
        button9_Text.text == "#")
        {
            return;
        }

        // 모든 칸이 완성됐지만 승부가 안 났을 때
        if (button1_Text.text != "#" &&
        button2_Text.text != "#" &&
        button3_Text.text != "#" &&
        button4_Text.text != "#" &&
        button5_Text.text != "#" &&
        button6_Text.text != "#" &&
        button7_Text.text != "#" &&
        button8_Text.text != "#" &&
        button9_Text.text != "#")
        {
            // 무승부
            result_Text.text = "End....";
            Reset();
        }

    }

    void Reset()
    {
        button1_Text.text = "#";
        button2_Text.text = "#";
        button3_Text.text = "#";
        button4_Text.text = "#";
        button5_Text.text = "#";
        button6_Text.text = "#";
        button7_Text.text = "#";
        button8_Text.text = "#";
        button9_Text.text = "#";

        isComTurn = false;
    }
}