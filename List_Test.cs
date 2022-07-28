using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class List_Test : MonoBehaviour
{
    // 1. 인트 자료형으로 배열을 만들어서 안에 원하는 값 5개 이상 넣기
    public int[] intArray2 = { 1, 2, 3, 4, 80 };

    // 2. 새로운 리스트 생성
    public List<int> intList = new List<int>();

    // Start is called before the first frame update
    void Start()
    {
        // 3. 1번에서 만든 배열을 2번에서 만든 리스트에 넣기
        intList = intArray2.ToList<int>();

        foreach (var item in intList)
        {
            print(item);
        }

        // 4. 리스트 안에 80이라는 값이 있는지 확인하고, 있다면 몇 번째에 있는지 번호 출력
        if (intList.Contains(80)) 
        {
            print(intList.IndexOf(80));
        }
        else
        {
            print("값이 없습니다.");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
