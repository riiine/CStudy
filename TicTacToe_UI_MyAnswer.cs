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

    public TextMeshProUGUI result_Text; // ��� �ؽ�Ʈ

    bool isComTurn; // ���� ��������



    // Start is called before the first frame update
    void Start()
    {
        Reset();

        if (button1 != null)
            button1.onClick.AddListener(Button1Func);
        //�Լ� ������ ��� ���
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

    void Button1Func() // Button1 ������ �� ���� �Լ�
    {
        if (button1_Text.text == "#")
        {
            if (isComTurn == false) // ���� ���ʶ��
            {
                button1_Text.text = "O";

                isComTurn = !isComTurn; // �� �ٲٱ�


            }
            else
            {
                button1_Text.text = "X";

                isComTurn = !isComTurn; // �� �ٲٱ�

            }
            Check(); // �ºθ� üũ�ϴ� �Լ�
        }

    }

    void Button2Func() // Button2 ������ �� ���� �Լ�
    {
        if (button2_Text.text == "#")
        {
            if (isComTurn == false) // ���� ���ʶ��
            {
                button2_Text.text = "O";

                isComTurn = !isComTurn; // �� �ٲٱ�


            }
            else
            {
                button2_Text.text = "X";

                isComTurn = !isComTurn; // �� �ٲٱ�

            }
            Check(); // �ºθ� üũ�ϴ� �Լ�
        }
    }
    void Button3Func() // Button3 ������ �� ���� �Լ�
    {
        if (button3_Text.text == "#")
        {
            if (isComTurn == false) // ���� ���ʶ��
            {
                button3_Text.text = "O";

                isComTurn = !isComTurn; // �� �ٲٱ�

            }
            else
            {
                button3_Text.text = "X";

                isComTurn = !isComTurn; // �� �ٲٱ�


            }
            Check(); // �ºθ� üũ�ϴ� �Լ�
        }
    }
    void Button4Func() // Button4 ������ �� ���� �Լ�
    {
        if (button4_Text.text == "#")
        {
            if (isComTurn == false) // ���� ���ʶ��
            {
                button4_Text.text = "O";

                isComTurn = !isComTurn; // �� �ٲٱ�


            }
            else
            {
                button4_Text.text = "X";

                isComTurn = !isComTurn; // �� �ٲٱ�


            }
            Check(); // �ºθ� üũ�ϴ� �Լ�
        }
    }
    void Button5Func() // Button5 ������ �� ���� �Լ�
    {
        if (button5_Text.text == "#")
        {
            if (isComTurn == false) // ���� ���ʶ��
            {
                button5_Text.text = "O";

                isComTurn = !isComTurn; // �� �ٲٱ�


            }
            else
            {
                button5_Text.text = "X";

                isComTurn = !isComTurn; // �� �ٲٱ�

            }
            Check(); // �ºθ� üũ�ϴ� �Լ�
        }
    }
    void Button6Func() // Button6 ������ �� ���� �Լ�
    {
        if (button6_Text.text == "#")
        {
            if (isComTurn == false) // ���� ���ʶ��
            {
                button6_Text.text = "O";

                isComTurn = !isComTurn; // �� �ٲٱ�


            }
            else
            {
                button6_Text.text = "X";

                isComTurn = !isComTurn; // �� �ٲٱ�


            }
            Check(); // �ºθ� üũ�ϴ� �Լ�
        }
    }
    void Button7Func() // Button7 ������ �� ���� �Լ�
    {
        if (button7_Text.text == "#")
        {
            if (isComTurn == false) // ���� ���ʶ��
            {
                button7_Text.text = "O";

                isComTurn = !isComTurn; // �� �ٲٱ�


            }
            else
            {
                button7_Text.text = "X";

                isComTurn = !isComTurn; // �� �ٲٱ�


            }
            Check(); // �ºθ� üũ�ϴ� �Լ�
        }
    }
    void Button8Func() // Button8 ������ �� ���� �Լ�
    {
        if (button8_Text.text == "#")
        {
            if (isComTurn == false) // ���� ���ʶ��
            {
                button8_Text.text = "O";

                isComTurn = !isComTurn; // �� �ٲٱ�


            }
            else
            {
                button8_Text.text = "X";

                isComTurn = !isComTurn; // �� �ٲٱ�


            }
            Check(); // �ºθ� üũ�ϴ� �Լ�
        }
    }
    void Button9Func() // Button9 ������ �� ���� �Լ�
    {
        if (button9_Text.text == "#")
        {
            if (isComTurn == false) // ���� ���ʶ��
            {
                button9_Text.text = "O";

                isComTurn = !isComTurn; // �� �ٲٱ�

            }
            else
            {
                button9_Text.text = "X";

                isComTurn = !isComTurn; // �� �ٲٱ�


            }
            Check(); // �ºθ� üũ�ϴ� �Լ�
        }
    }

    void Check()
    {
        // ���� 3�� �˻�
        if (button1_Text.text != "#" && button1_Text.text == button2_Text.text && button1_Text.text == button3_Text.text)
        {
            print("����");
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
        // ���� 3�� �˻�
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

        // �밢�� \ �˻�
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

        // �밢�� / �˻�
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

        // ��� ĭ�� ���� "#" �� ��
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

        // ��� ĭ�� �ϼ������� �ºΰ� �� ���� ��
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
            // ���º�
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