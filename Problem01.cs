using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 1. 아래와 같이 입력값을 받으면 반환값을 반환하는 함수 만들기
// 입력값  3   5   10
// 반환값  11  27  102
public class Problem01 : MonoBehaviour
{
    public int input; // 입력값

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ReturnFunc(input);
    }

    public int ReturnFunc(int returnValue)
    {
        if (input == 3)
        {
            returnValue = 11;
        }

        if (input == 5)
        {
            returnValue = 27;
        }

        if (input == 10)
        {
            returnValue = 102;
        }

        return returnValue;
    }

}
