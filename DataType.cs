/** 2022.07.17 복습완료 */



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataType : MonoBehaviour
{
    // 필드
    float speed; // 변수 선언

    string myName = "석윤경";

    // Start is called before the first frame update
    void Start()
    {
        print(48 % 2); // 정수 0 1 2 100 -4 (int)

        print(1 / 10.0f); // 실수 (float)

        print('안'); // 문자 (char)

        print("안녕" + "하세요" + (3 + 3)); // 문자열 (string) : 덧셈>이어붙이기

        print(!(1 < 3)); // 불 (bool) : 참(true)과 거짓(false)

        speed = 0; // 할당

        int hp = 100; // 변수 선언 + 할당

        speed = 10;

        print(speed);

        int S2peed2 = 1;

        /*
        [식별자 정할 때 규칙]
        1. 키워드는 사용할 수 없음 (키워드 : 이미 의미를 갖고 있는 단어)
        2. 공백,특수문자 사용 불가 (단, 언더바(_)는 사용 가능)
        3. 숫자로 시작하면 안 됨

        [개발자들끼리의 약속]
        1. 변수는 소문자로 시작, 함수/클래스는 대문자로 시작
        2. 의미없는 단어 말고, 추측 가능한 의미있는 이름
        3. 여러단어로 이루어진 경우, 각 단어의 첫글자를 대문자로 한다
         */

        int a = 10;
        float b = 2.5f;

        print("a + b");

        // 복합 대입 연산자
        a += 5;
        a -= 3;
        a *= 10;
        a /= 2;
        print(a);

        string c = "안녕";
        c += "하세요";
        print(c);

        // 증감 연산자
        int d = 10;
        print(d++); // 후위 : 다음 줄로 넘어갈 때 적용
        print(d--);

        print(++d); // 전위 : 이번 줄에서 바로 적용
        print(--d);

        // 10
        print(d++); // 10
        print(++d); // 12
        print(d--); // 12
        print(--d); // 10

        int e = 2;
        e += 1;
        e *= 2;
        e--;
        --e;
        print(e++);
        print(e);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
