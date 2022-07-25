/** 2022.07.25 복습완료 */



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 1번 답
class Car
{
    string color = "빨간색";
    int wheelCount = 4;

    void Go()
    {

    }

    void Stop()
    {

    }
}

public class Test1 : MonoBehaviour
{
    // 3번 답
    float Circle(float radius)
    {
        return radius * 2 * 3.14f;
    }

    int x, y;
    // Start is called before the first frame update
    void Start()
    {
        // 4번 답
        if(x < 30 && x > 0 && y == 10)
        {
            print("x와 y는 조건에 만족했습니다.");
        }

        rand = Random.Range(0, 2);
        if(rand == 0)
        {
            print("왼쪽");
        }
        else
        {
            print("오른쪽");
        }
    }
    int rand;
    bool isCan = true;

    // Update is called once per frame
    void Update()
    {
        // 5번 답
        if (isCan)
        {
            if (Input.GetKeyDown(KeyCode.Alpha0))
            {
                print(0);
            }
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                print(1);
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            isCan = false;
        }

        if((Input.GetKeyDown(KeyCode.LeftArrow) && rand == 0)
            || (Input.GetKeyDown(KeyCode.RightArrow) && rand == 1))
        {
            print("딩동댕");
        }
        else if((Input.GetKeyDown(KeyCode.LeftArrow) && rand == 1)
            || (Input.GetKeyDown(KeyCode.RightArrow) && rand == 0))
        {
            print("땡");
        }
    }
}
