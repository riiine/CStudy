using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Function : MonoBehaviour
{
    public string name;

    // [접근제한자]
    // public : 외부에서 사용이 가능
    // private : 외부에서 사용이 불가능 (생략가능)

    // Start is called before the first frame update
    void Start()
    {
        //float z = 0f;

        //Addition(1, 2, out z);

        //print(z);

        ////int test = Addition(1, 2);

        //Addition2(5);

        //print(System.DateTime.Now.ToString("yyyy"));

        //print(AgeCal(1994));

        print("스타트함수");
    }

    void Update()
    {
        print("업데이트함수");
    }

    // 나이 계산 함수
    int AgeCal(int birthYear)
    {
        // 현재년도 구해서 변수로 저장
        string nowYear = System.DateTime.Now.ToString("yyyy");

        // 현재년도 - 출생년도 반환
        return int.Parse(nowYear) - birthYear + 1;
    }

    public int Addition(int x)
    {
        return x + 1;
    }

    int Addition(int x, int y, out float z)
    {
        z = 3.5f;

        return x + y;
    }

    void Addition2(int x)
    {
        print(x + 1);
    }

    void Addition()
    {
        int x = 1;
        int y = 5;

        print(x + y);
    }

    // 1. 매개변수 : 함수를 호출할 때 특정 값을 보내주기 위해
    // 2. 반환값 : 함수의 결과값을 받아오기 위해
    // 3. out, ref : 반대로(부르는 사람한테 보내는 값 = 반환값)
}
