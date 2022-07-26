using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TicTacToe : MonoBehaviour
{
    // ���̺� �����
    string[,] table = new string[3, 3];

    // ������ ���� ����
    bool isX;

    // Start is called before the first frame update
    void Start()
    {
        // ���̺� # �ֱ�
        for (int i = 0; i < table.GetLength(0); i++)
        {
            for (int j = 0; j < table.GetLength(1); j++)
            {
                table[i, j] = "#";
            }
        }

        // ���̺� 3x3���� ���
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

    // ���̺� ���
    void TablePrint()
    {
        // ���̺� 3x3���� ���
        string result = "";

        for (int i = 0; i < table.GetLength(0); i++)
        {
            for (int j = 0; j < table.GetLength(1); j++)
            {
                // ���� ����� ���� ����
                result += table[i, j] + " ";
            }

            // �ٹٲ�
            result += "\n";
        }

        print(result);
    }

    // Ű�е带 ������ ȣ��
    void InputKeypad(int i, int j)
    {
        // �� ������ �������� ����
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

            // �� �ٲٱ�
            isX = !isX;

            // üũ
            Check();
        }
        else
        {
            print("�ٸ� ĭ�� �����ϼ���.");
        }
    }

    void Check()
    {
        // ���� 3�� �˻�
        for (int i = 0; i < 3; i++)
        {
            // #�� �ƴϰ�, �� ������ ���� ���ٸ�
            if (table[i, 0] != "#" && table[i, 0] == table[i, 1] && table[i, 0] == table[i, 2])
            {
                print($"{table[i, 0]}�� �¸�");
                RestTable();
                return;
            }
        }

        // ���� 3�� �˻�
        for (int i = 0; i < 3; i++)
        {
            // #�� �ƴϰ�, �� ������ ���� ���ٸ�
            if (table[0, i] != "#" && table[0, i] == table[1, i] && table[0, i] == table[2, i])
            {
                print($"{table[0, i]}�� �¸�");
                RestTable();
                return;
            }
        }

        // �밢�� \ �˻�
        if (table[0, 0] != "#" && table[0, 0] == table[1, 1] && table[1, 1] == table[2, 2])
        {
            print($"{table[0, 0]}�� �¸�");
            RestTable();
            return;
        }
        // �밢�� / �˻�
        if (table[0, 2] != "#" && table[0, 2] == table[1, 1] && table[1, 1] == table[2, 0])
        {
            print($"{table[0, 2]}�� �¸�");
            RestTable();
            return;
        }

        // ����, ����, �밢�� ������ �� �ư�, ���� ���º� �ƴ� ��
        foreach (var item in table)
        {
            if (item == "#")
            {
                return;
            }
        }

        // ����, ����, �밢�� ������ �� �ư�, ���ºζ��
        print("���º�");
        RestTable();
    }

    // ���� ��, �ʱ�ȭ
    void RestTable()
    {
        print("�ٽ� �����ϼ���.");

        // ���̺� # �ֱ�
        for (int i = 0; i < table.GetLength(0); i++)
        {
            for (int j = 0; j < table.GetLength(1); j++)
            {
                table[i, j] = "#";
            }
        }

        TablePrint();

        // �� �ʱ�ȭ
        isX = false;
    }
}
