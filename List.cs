using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class List : MonoBehaviour
{
    // 인트 자료형의 리스트 
    public List<int> intList = new List<int>();

    public List<int> intList2 = new List<int>() { 1, 2 };

    // Start is called before the first frame update
    void Start()
    {
        List<float> floatList = new List<float>();
        List<string> stringList = new List<string>();
        List<bool> boolList = new List<bool>();

        // 값 추가
        intList.Add(5);
        intList.Add(4);
        intList.Add(3);
        intList.Add(2);
        intList.Add(1);

        // 값 교체
        intList[0] = 10;

        // 리스트에 있는 모든 값 출력 - 포문 + 폴이치문
        for(int i=0; i < intList.Count; i++)
        {
            print(intList[i]);
        }

        foreach(var item in intList)
        {
            print(item);
        }

        // 값 삭제
        intList.RemoveAt(4);
        intList.RemoveAt(3);

        // 중간에 값 추가
        intList.Insert(1, 20);

        // 리스트 > 배열
        int[] intArray = intList.ToArray();
        foreach (var item in intArray)
        {
            print(item);
        }

        // 배열 > 리스트
        string[] stringArray = { "가", "나", "다", "라" };
        stringList = stringArray.ToList<string>();
        foreach(var item in stringList)
        {
            print(item);
        }

        // 리스트 추가 (합치기)
        intList.AddRange(intList2);

        //intList2 = intList; // 이렇게 하면 안 됨. 참조라서 값이 같이 바뀜

        // intList2에 intList의 모든 값을 할당하되, 독립적이게 하기
        intList2.Clear();
        intList2.AddRange(intList);
        //intList2 = intList.ToList(); // 내가 쓴 답
        //foreach(var item in intList)
        //{
        //    intList2.Add(item);
        //}

        // 리스트 안에 있는지 없는지
        print(intList.Contains(100));

        // 인덱스 확인
        print(stringList.IndexOf("나"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
