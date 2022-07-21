using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAnswer : MonoBehaviour
{
    public string m_UserSelect; // ����� ����
    public string m_ComSelect; // ��ǻ�� ����
    int m_UserScore = 0; // ������� ���ھ� ����
    int m_ComScore = 0; // ��ǻ���� ���ھ� ����
    int m_win = 0; // �¸���

    int gameCount = 0; // ���� ���� Ƚ��

    public bool isEnd; // �������� �Ǵ�

    // Start is called before the first frame update
    void Start()
    {
        // �������ڸ��� "����, ����, �� �� �ϳ��� �Է��ϼ���" ���
        // �ν����� â���� ���̴� ����(m_UserSelect)�� ����, ����, �� �� �ϳ��� �Է�
        print("������� �����ϱ� ��, ����, ����, �� �� �ϳ��� �Է��ϼ���.");
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Return))
        {
            // 0 : ����, 1 : ����, 2 : ��
            // ����Ű�� ������ ��ǻ�͵� ����, ����, �� �� �ϳ��� �������� ����
            int random = Random.Range(0, 3);

            while (true)
            {
                if (random == 0)
                {
                    m_ComSelect = "����";

                    if (m_UserSelect == "����") // ���º�
                    {
                        gameCount++;
                        print($"�� : {m_UserSelect} ,��ǻ�� : {m_ComSelect}, ��� : ���º�");
                    }
                    if (m_UserSelect == "����")
                    {
                        gameCount++;
                        m_UserScore++; // ������ �̰����Ƿ� ���� ���ھ� ����
                        m_win++; // �¸��� ����
                        print($"�� : {m_UserSelect} ,��ǻ�� : {m_ComSelect}, ��� : ���� �¸�");
                        break;
                    }
                    if (m_UserSelect == "��")
                    {
                        gameCount++;
                        m_ComScore++; // ��ǻ�Ͱ� �̰����Ƿ� ��ǻ�� ���ھ� ����
                        print($"�� : {m_UserSelect} ,��ǻ�� : {m_ComSelect}, ��� : ��ǻ�� �¸�");
                    }
                }
                if (random == 1)
                {
                    m_ComSelect = "����";

                    if (m_UserSelect == "����")
                    {
                        gameCount++;
                        m_UserScore++; // ������ �̰����Ƿ� ���� ���ھ� ����
                        m_win++; // �¸��� ����
                        print($"�� : {m_UserSelect} ,��ǻ�� : {m_ComSelect}, ��� : ���� �¸�");
                        break;
                    }
                    if (m_UserSelect == "����") // ���º�
                    {
                        gameCount++;
                        print($"�� : {m_UserSelect} ,��ǻ�� : {m_ComSelect}, ��� : ���º�");
                    }
                    if (m_UserSelect == "��")
                    {
                        gameCount++;
                        m_ComScore++; // ��ǻ�Ͱ� �̰����Ƿ� ��ǻ�� ���ھ� ����
                        print($"�� : {m_UserSelect} ,��ǻ�� : {m_ComSelect}, ��� : ��ǻ�� �¸�");
                    }
                }
                if (random == 2)
                {
                    m_ComSelect = "��";

                    if (m_UserSelect == "����")
                    {
                        gameCount++;
                        m_UserScore++; // ������ �̰����Ƿ� ���� ���ھ� ����
                        m_win++; // �¸��� ����
                        print($"�� : {m_UserSelect} ,��ǻ�� : {m_ComSelect}, ��� : ���� �¸�");
                        break;
                    }
                    if (m_UserSelect == "����")
                    {
                        gameCount++;
                        m_ComScore++; // ��ǻ�Ͱ� �̰����Ƿ� ��ǻ�� ���ھ� ����
                        print($"�� : {m_UserSelect} ,��ǻ�� : {m_ComSelect}, ��� : ��ǻ�� �¸�");
                    }
                    if (m_UserSelect == "��") // ���º�
                    {
                        gameCount++;
                        print($"�� : {m_UserSelect} ,��ǻ�� : {m_ComSelect}, ��� : ���º�");
                    }

                }
                continue;
            }    
            
        }

        while (true)
        {
            if (m_win == 1) // ���� ������ ��
            {
                print("�� : ����, ��ǻ�� : ���� �Դϴ�. ��, ��, �� �� �ϳ��� �Է��ϼ���.");

                if (Input.GetKeyDown(KeyCode.Return))
                {
                    // 0 : ��, 1 : ��, 2 : ��
                    // ����Ű�� ������ ��ǻ�͵� ��, ��, �� �� �ϳ��� �������� ����
                    int random = Random.Range(0, 3);

                    if (random == 0)
                    {
                        m_ComSelect = "��";

                        if (m_UserSelect == "��")
                        {
                            gameCount++;
                            print($"�� : {m_UserSelect} ,��ǻ�� : {m_ComSelect}, ��� : ���� �¸�");
                            m_UserScore++; // ������ �̰����Ƿ� ���� ���ھ� ����
                            break;
                        }
                        if (m_UserSelect == "��")
                        {
                            gameCount++;
                            print($"�� : {m_UserSelect} ,��ǻ�� : {m_ComSelect}, ��� : ��������");
                            m_win = 2; // ���������Ͽ� ������ ���� ��
                            continue;
                        }
                        if (m_UserSelect == "��")
                        {
                            gameCount++;
                            print($"�� : {m_UserSelect} ,��ǻ�� : {m_ComSelect}, ��� : �̾");
                            continue;
                        }
                    }
                    if (random == 1)
                    {
                        m_ComSelect = "��";

                        if (m_UserSelect == "��")
                        {
                            gameCount++;
                            print($"�� : {m_UserSelect} ,��ǻ�� : {m_ComSelect}, ��� : �̾");
                            continue;
                        }
                        if (m_UserSelect == "��") // ������ �̰����Ƿ� ���� ���ھ� ����
                        {
                            gameCount++;
                            print($"�� : {m_UserSelect} ,��ǻ�� : {m_ComSelect}, ��� : ���� �¸�");
                            m_UserScore++; // ������ �̰����Ƿ� ���� ���ھ� ����
                            break;
                        }
                        if (m_UserSelect == "��")
                        {
                            gameCount++;
                            print($"�� : {m_UserSelect} ,��ǻ�� : {m_ComSelect}, ��� : ��������");
                            m_win = 2; // ���������Ͽ� ������ ���� ��
                            continue;
                        }
                    }
                    if (random == 2)
                    {
                        m_ComSelect = "��";

                        if (m_UserSelect == "��")
                        {
                            gameCount++;
                            print($"�� : {m_UserSelect} ,��ǻ�� : {m_ComSelect}, ��� : ��������");
                            m_win = 2; // ���������Ͽ� ������ ���� ��
                            continue;
                        }
                        if (m_UserSelect == "��")
                        {
                            gameCount++;
                            print($"�� : {m_UserSelect} ,��ǻ�� : {m_ComSelect}, ��� : �̾");
                            continue;
                        }
                        if (m_UserSelect == "��")
                        {
                            gameCount++;
                            print($"�� : {m_UserSelect} ,��ǻ�� : {m_ComSelect}, ��� : ���� �¸�");
                            m_UserScore++; // ������ �̰����Ƿ� ���� ���ھ� ����
                            break;
                        }
                    }

                }
            }

            if (m_win == 2) // ���� ������ ��
            {
                print("�� : ����, ��ǻ�� : ���� �Դϴ�. ��, ��, �� �� �ϳ��� �Է��ϼ���.");

                if (Input.GetKeyDown(KeyCode.Return))
                {
                    // 0 : ��, 1 : ��, 2 : ��
                    // ����Ű�� ������ ��ǻ�͵� ��, ��, �� �� �ϳ��� �������� ����
                    int random = Random.Range(0, 3);

                    if (random == 0)
                    {
                        m_ComSelect = "��";

                        if (m_UserSelect == "��")
                        {
                            gameCount++;
                            print($"�� : {m_UserSelect} ,��ǻ�� : {m_ComSelect}, ��� : ��ǻ�� �¸�");
                            m_ComScore++; // ��ǻ�Ͱ� �̰����Ƿ� ��ǻ�� ���ھ� ����
                            break;
                        }
                        if (m_UserSelect == "��")
                        {
                            gameCount++;
                            print($"�� : {m_UserSelect} ,��ǻ�� : {m_ComSelect}, ��� : �̾");
                            continue;
                        }
                        if (m_UserSelect == "��")
                        {
                            gameCount++;
                            print($"�� : {m_UserSelect} ,��ǻ�� : {m_ComSelect}, ��� : ��������");
                            m_win = 1; // ���������Ͽ� ������ ������ ��
                            continue;
                        }
                    }
                    if (random == 1)
                    {
                        m_ComSelect = "��";

                        if (m_UserSelect == "��")
                        {
                            gameCount++;
                            print($"�� : {m_UserSelect} ,��ǻ�� : {m_ComSelect}, ��� : ��������");
                            m_win = 1; // ���������Ͽ� ������ ������ ��
                            continue;
                        }
                        if (m_UserSelect == "��")
                        {
                            gameCount++;
                            print($"�� : {m_UserSelect} ,��ǻ�� : {m_ComSelect}, ��� : ��ǻ�� �¸�");
                            m_ComScore++; // ��ǻ�Ͱ� �̰����Ƿ� ��ǻ�� ���ھ� ����
                            break;
                        }
                        if (m_UserSelect == "��")
                        {
                            gameCount++;
                            print($"�� : {m_UserSelect} ,��ǻ�� : {m_ComSelect}, ��� : �̾");
                            continue;
                        }
                    }
                    if (random == 2)
                    {
                        m_ComSelect = "��";

                        if (m_UserSelect == "��")
                        {
                            gameCount++;
                            print($"�� : {m_UserSelect} ,��ǻ�� : {m_ComSelect}, ��� : �̾");
                            continue;
                        }
                        if (m_UserSelect == "��")
                        {
                            gameCount++;
                            print($"�� : {m_UserSelect} ,��ǻ�� : {m_ComSelect}, ��� : ��������");
                            m_win = 1; // ���������Ͽ� ������ ������ ��
                            continue;
                        }
                        if (m_UserSelect == "��")
                        {
                            gameCount++;
                            print($"�� : {m_UserSelect} ,��ǻ�� : {m_ComSelect}, ��� : ���� �¸�");
                            m_ComScore++; // ��ǻ�Ͱ� �̰����Ƿ� ��ǻ�� ���ھ� ����
                            print($"��������!! �� : {m_UserSelect} ,��ǻ�� : {m_ComSelect}, ��������Ƚ�� : {gameCount}, ���� ���ھ� : {m_UserScore} : {m_ComScore}");
                            break;
                        }
                    }

                }
            }
            return;
        }


    }

}
