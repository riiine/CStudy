using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 1�� ��
class Car
{
    string color = "������";
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
    // 3�� ��
    float Circle(float radius)
    {
        return radius * 2 * 3.14f;
    }

    int x, y;
    // Start is called before the first frame update
    void Start()
    {
        // 4�� ��
        if(x < 30 && x > 0 && y == 10)
        {
            print("x�� y�� ���ǿ� �����߽��ϴ�.");
        }

        rand = Random.Range(0, 2);
        if(rand == 0)
        {
            print("����");
        }
        else
        {
            print("������");
        }
    }
    int rand;
    bool isCan = true;

    // Update is called once per frame
    void Update()
    {
        // 5�� ��
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
            print("������");
        }
        else if((Input.GetKeyDown(KeyCode.LeftArrow) && rand == 1)
            || (Input.GetKeyDown(KeyCode.RightArrow) && rand == 0))
        {
            print("��");
        }
    }
}
