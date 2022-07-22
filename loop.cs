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
            print("반복");
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

        // 반복문을 이용해서 5부터 15까지 출력하는 코드 
        for (int i = 5; i <= 15; i++)
        {
            print(i);
        }

        // 반복문을 이용해서 1부터 10까지 중에서 짝수만 출력
        // 나머지 연산을 사용하지 않고!
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
                print("반복");
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

        // break : 조건문/반복문을 탈출
        // continue : 반복문 안에서 진행되던 코드를 탈출 > 다음 반복
        // return : 함수를 탈출
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
