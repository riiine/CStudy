using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int count = 0;

        while (count < 10)
        {
            print("�ݺ�");
            count++;
        }

        do
        {
            print("doWhile");
            count++;
        } while (count < 10);

        for(int i = 0; i < 1000; i++)
        {
            print(i);
        }

        // �ݺ����� �̿��ؼ� 5���� 15���� ����ϴ� �ڵ� 
        for (int i = 5; i <= 15; i++)
        {
            print(i);
        }

        // �ݺ����� �̿��ؼ� 1���� 10���� �߿��� ¦���� ���
        // ������ ������ ������� �ʰ�!
        for (int i = 2; i <= 10; i+=2)
        {
            print(i);
        }

        for (int i = 10; i > 0;)
        {
            i--;
            print(i);
        }

        for (int i=0; i<4; i++)
        {
            for (int j=0; j<4; j++)
            {
                print("�ݺ�");
            }
        }

        string result = "";

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                result += "*";
            }
            result += "\n";

            if(i == 4)
            {
                break;
            }
        }

        print(result);

        for (int i = 1; i <= 10; i++)
        {
            if(i % 2 != 0)
            {
                continue;
            }

            print(i);
        }

        // break : ���ǹ�/�ݺ����� Ż��
        // continue : �ݺ��� �ȿ��� ����Ǵ� �ڵ带 Ż�� > ���� �ݺ�
        // return : �Լ��� Ż��
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
