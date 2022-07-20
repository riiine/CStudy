using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockScissorPaper : MonoBehaviour
{
    public string m_UserSelect; // ����� ����
    public string m_ComSelect; // ��ǻ�� ����
    int m_UserScore = 0; // ������� ���ھ� ����
    int m_ComScore = 0; // ��ǻ���� ���ھ� ����

    int gameCount = 0; // ���� ���� Ƚ��

    string result = ""; // ���

    public bool isEnd; // �������� �Ǵ�

    // Start is called before the first frame update
    void Start()
    {
        // �������ڸ��� "����, ����, �� �� �ϳ��� �Է��ϼ���" ���
        // �ν����� â���� ���̴� ����(m_UserSelect)�� ����, ����, �� �� �ϳ��� �Է�
        print("����, ����, �� �� �ϳ��� �Է��ϼ���.");
    }

    // Update is called once per frame
    void Update()
    {
        // ������ ����ƴٸ�
        if (isEnd)
        {
            return;
        }

        if (gameCount < 5) 
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                // 0 : ����, 1 : ����, 2 : ��
                // ����Ű�� ������ ��ǻ�͵� ����, ����, �� �� �ϳ��� �������� ����
                int random = Random.Range(0, 3);

                if (random == 0)
                {
                    m_ComSelect = "����";

                    if (m_UserSelect == "����") // ���º�
                    {
                        gameCount++;
                        print($"�� : {m_UserSelect} ,��ǻ�� : {m_ComSelect}, ��� : ���º�, ���� ���ھ� : {m_UserScore} : {m_ComScore}");
                    }
                    if (m_UserSelect == "����")
                    {
                        gameCount++;
                        m_UserScore++; // ������ �̰����Ƿ� ���� ���ھ� ����
                        print($"�� : {m_UserSelect} ,��ǻ�� : {m_ComSelect}, ��� : ���� �¸�, ���� ���ھ� : {m_UserScore} : {m_ComScore}");
                    }
                    if (m_UserSelect == "��")
                    {
                        gameCount++;
                        m_ComScore++; // ��ǻ�Ͱ� �̰����Ƿ� ��ǻ�� ���ھ� ����
                        print($"�� : {m_UserSelect} ,��ǻ�� : {m_ComSelect}, ��� : ��ǻ�� �¸�, ���� ���ھ� : {m_UserScore} : {m_ComScore}");
                    }
                }
                if (random == 1)
                {
                    m_ComSelect = "����";

                    if (m_UserSelect == "����")
                    {
                        gameCount++;
                        m_UserScore++; // ������ �̰����Ƿ� ���� ���ھ� ����
                        print($"�� : {m_UserSelect} ,��ǻ�� : {m_ComSelect}, ��� : ���� �¸�, ���� ���ھ� : {m_UserScore} : {m_ComScore}");
                    }
                    if (m_UserSelect == "����") // ���º�
                    {
                        gameCount++;
                        print($"�� : {m_UserSelect} ,��ǻ�� : {m_ComSelect}, ��� : ���º�, ���� ���ھ� : {m_UserScore} : {m_ComScore}");
                    }
                    if (m_UserSelect == "��")
                    {
                        gameCount++;
                        m_ComScore++; // ��ǻ�Ͱ� �̰����Ƿ� ��ǻ�� ���ھ� ����
                        print($"�� : {m_UserSelect} ,��ǻ�� : {m_ComSelect}, ��� : ��ǻ�� �¸�, ���� ���ھ� : {m_UserScore} : {m_ComScore}");
                    }
                }
                if (random == 2)
                {
                    m_ComSelect = "��";

                    if (m_UserSelect == "����")
                    {
                        gameCount++;
                        m_UserScore++; // ������ �̰����Ƿ� ���� ���ھ� ����
                        print($"�� : {m_UserSelect} ,��ǻ�� : {m_ComSelect}, ��� : ���� �¸�, ���� ���ھ� : {m_UserScore} : {m_ComScore}");
                    }
                    if (m_UserSelect == "����")
                    {
                        gameCount++;
                        m_ComScore++; // ��ǻ�Ͱ� �̰����Ƿ� ��ǻ�� ���ھ� ����
                        print($"�� : {m_UserSelect} ,��ǻ�� : {m_ComSelect}, ��� : ��ǻ�� �¸�, ���� ���ھ� : {m_UserScore} : {m_ComScore}");
                    }
                    if (m_UserSelect == "��") // ���º�
                    {
                        gameCount++;
                        print($"�� : {m_UserSelect} ,��ǻ�� : {m_ComSelect}, ��� : ���º�, ���� ���ھ� : {m_UserScore} : {m_ComScore}");
                    }
                }

            }
        }

        if (gameCount == 5) // 5���� ����Ǹ�
        {
            // ���� ����
            isEnd = true;

            if (m_UserScore > m_ComScore) 
            {
                result = "���� �¸�";
            }
            if (m_UserScore < m_ComScore)
            {
                result = "��ǻ�� �¸�";
            }
            if (m_UserScore == m_ComScore)
            {
                result = "���º�";
            }

            print($"��������!! �� : {m_UserSelect} ,��ǻ�� : {m_ComSelect}, ��� : {result}, ���� ���ھ� : {m_UserScore} : {m_ComScore}");
        }

    }
    
}
