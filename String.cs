using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class String : MonoBehaviour
{
    public string memo = "안녕하세요 저는 이하린입니다 잘 부탁해요";

    // Start is called before the first frame update
    void Start()
    {
        // 문자열의 길이 = 문자의 개수
        print(memo.Length);

        // '벽'이라는 단어가 있으면 있음, 없으면 없음
        if (memo.Contains("벽"))
        {
            print("있음");
        }
        else
        {
            print("없음");
        }

        // 몇 번째에 있는지 (없으면 -1)
        print(memo.IndexOf("벽"));

        // 값 지우기 (제대로 적용되도록 해결해보기)
        memo = memo.Remove(9, 1); // 9번부터 1개 삭제

        // 중간에 값 추가
        memo = memo.Insert(6, "반갑습니다"); // 6번에 값 추가

        // 뒤에 값 추가 (!)
        memo += "!";

        // 값 바꾸기
        memo = memo.Replace("요", "용");

        // 비속어 *로 바꾸기
        memo = memo.Replace("바보", "**");

        // 값으로 지우기
        memo = memo.Replace("반갑습니다.", "");

        // 첫번째 요만 용으로 바꾸기
        int index = memo.IndexOf("요");
        memo = memo.Remove(index, 1);
        memo = memo.Insert(index, "용");

        // 문자열 > 문자 배열
        char[] charArray = memo.ToCharArray();
        foreach (var item in charArray)
        {
            print(item);
        }

        // 문자열 > 문자열 배열 (띄어쓰기 기준)
        char[] separator = { ',', '@', '_', '/' };
        string[] stringArray = memo.Split(separator);
        foreach (var item in stringArray)
        {
            print(item);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
