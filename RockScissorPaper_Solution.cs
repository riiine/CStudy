using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockScissorPaper_Solution : MonoBehaviour
{
    // 2-1. �÷��̾ ����
    public string myChoice;

    // 2-2. ��ǻ�Ͱ� ����
    string comChoice;

    // 2-5. �� ���� ���
    string result;

    // 2-7. ���ھ�
    int myScore, comScore;

    // 3-1. ���� Ƚ��
    int gameCount;

    // Start is called before the first frame update
    void Start()
    {
        // 1. ���� ��Ʈ
        print("����, ����, �� �� �ϳ��� �Է��ϼ���.");
    }

    // Update is called once per frame
    void Update()
    {
        // 3-4. ������ 5�� �ߴٸ� �� �̻� ���� X
        if(gameCount >= 5)
        {
            return;
        }

        // 2-3. ����Ű�� ������
        if(Input.GetKeyDown(KeyCode.Return))
        {
            // 2-4. ��ǻ�͵� �� �� �ϳ� ����
            int rand = Random.Range(0, 3);
            switch(rand)
            {
                case 0: comChoice = "����"; break;
                case 1: comChoice = "����"; break;
                case 2: comChoice = "��"; break;
            }

            // 2-6. ���� �� �Ͱ� ��ǻ�Ͱ� �� �Ϳ� ���� ��� �ٸ���
            switch(myChoice)
            {
                case "����": 
                    switch(comChoice)
                    {
                        case "����":  result = "���º�"; break;
                        case "����": result = "��ǻ�� ��"; comScore++; break;
                        case "��": result = "�÷��̾� ��"; myScore++;  break;
                    }
                    break;

                case "����":
                    switch (comChoice)
                    {
                        case "����": result = "�÷��̾� ��"; myScore++; break;
                        case "����": result = "���º�"; break;
                        case "��": result = "��ǻ�� ��"; comScore++; break;
                    }
                    break;

                case "��":
                    switch (comChoice)
                    {
                        case "����": result = "��ǻ�� ��"; comScore++; break;
                        case "����": result = "�÷��̾�"; myScore++; break;
                        case "��": result = "���º�"; break;
                    }
                    break;
            }

            // 2-8. �� �Ǵ� ��� �� �� ���
            print($"�÷��̾� : {myChoice}, ��ǻ�� : {comChoice}" +
                $" {result}, ���ھ�(�÷��̾�:��ǻ��) {myScore} : {comScore}");

            // 3-2. ���� Ƚ�� ����
            gameCount++;

            // 3-3. ������ 5�� �ߴٸ�
            if (gameCount == 5)
            {
                // 3-5. ���ھ ���� ���� ��� �� �ٷ� ���
                if(myScore > comScore)
                {
                    print($"���� ��! �÷��̾� : ��ǻ�� = {myScore} : {comScore}, �÷��̾� ��");
                }
                else if(myScore < comScore)
                {
                    print($"���� ��! �÷��̾� : ��ǻ�� = {myScore} : {comScore}, ��ǻ�� ��");
                }
                else
                {
                    print($"���� ��! �÷��̾� : ��ǻ�� = {myScore} : {comScore}, ���º�");
                }
            }
        }
    }
}
