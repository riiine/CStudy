/** 2022.07.26 복습완료 */



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{        
    // 첫 번째 방법 : 값을 넣으면서 공간 크기 마련
    // 인트 배열 변수
    public int[] intArray = { 1, 2, 3 };

    // Start is called before the first frame update
    void Start()
    {
        // 플롯 배열 변수
        float[] floatArray = { 0.1f, 2.3f, 5f };

        // 스트링 배열 변수
        string[] stringArray = { "안녕", "하세요", "여러분" };

        // 불 배열 변수
        bool[] boolArray = { true, false, 1 < 2 };

        // 스트링어레이 값 전부 출력 (프린트 코드 한 번만 작성, 문자열 연결x)
        for (int i=0; i < stringArray.Length; i++) 
        {
            print(stringArray[i]);
        }

        // 스트링어레이 값 전부 출력
        foreach (var item in stringArray)
        {
            print(item); // get
            //item = "o"; // set
        }
        // 장점 : 컬렉션에 사용하기 편하다
        // 단점 : 반복 변수는 읽기 전용 (할당X)

        floatArray[0] = 1.1f;

        foreach (var item in floatArray)
        {
            print(item);
        }

        // 두 번째 방법 : 공간의 크기만 결정 (초기값이 들어감)
        int[] intArray2;
        intArray2 = new int[2];

        foreach (var item in intArray2)
        {
            print(item);
        }

        // 2차원 배열
        int[,] intArray3 = {
            { 1, 2, 3, 4, 5, 6},
            { 7, 8, 9, 10, 11, 12}
        };

        print(intArray3[1, 4]);

        // intArray3에 있는 모든 값 출력, foreach문 금지
        for (int i = 0; i < intArray3.GetLength(0); i++)
        {
            for (int j = 0; j < intArray3.GetLength(1); j++) 
            {
                print(intArray3[i, j]);
            }
        }

        int[,,] intArray4 = new int[2, 4, 3];

        // 가변 배열
        int[][] intArray5 = new int[3][];
        intArray5[0] = new int[6] { 1, 2, 3, 4, 5, 6 };
        intArray5[1] = new int[3];
        intArray5[2] = new int[5];

        int[][][] intArray6 = new int[3][][];
        intArray6[0] = new int[6][];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
