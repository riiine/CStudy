using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO; // 폴더 입출력
// 5. 좌클릭했을 때 처음이라면 바탕화면에
// 새로운 폴더와 그 안에 새로운 텍스트 문서를 생성하고,
// 처음이 아니라면 중복 없는 난수로 이루어진
// 5자리 수를 만들어 텍스트 문서 안에 입력하기
//(단, 5자리 수는 0으로 시작할 수 없다.) (*난수 : 랜덤한 수)
public class Problem05 : MonoBehaviour
{
    int count = 0;
    string numStr = ""; //난수가 저장될 변수
    
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (count == 0) // 처음이라면
            {
                // 폴더 생성
                Directory.CreateDirectory(@"C:\Users\D\Desktop\TestFolder");
                // 텍스트 문서 생성
                File.Create(@"C:\Users\D\Desktop\TestFolder\Test.txt");
                count++;
            }
            else // 처음이 아니라면
            {
                int random = Random.Range(1, 10);
                string ran = random.ToString();

                if (!numStr.Contains(ran)) 
                {
                    numStr += ran;

                    // 파일 안에 글쓰기
                    File.WriteAllText(@"C:\Users\D\Desktop\TestFolder\Test.txt", numStr);
                }
            }
            
        }
    }
}
