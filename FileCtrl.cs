using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO; // 파일 입출력

public class FileCtrl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 기본적으로 접근하기 편한 경로
        print(Application.persistentDataPath);

        // 기본적으로 접근하기 편한 경로에 파일 생성
        // 1. 어디에 생성할지
        // 2. 어떤 이름으로 생성할지
        // 3. 어떤 타입으로 생성할지
        File.Create(Application.persistentDataPath + "/Test.txt");
        // 같은 이름의 파일이 존재하면 덮어쓰기

        File.Create(@"C:\Users\D\Desktop\Test.txt");

        // 슬래시 사용 or 역슬래시+@
    }

    // Update is called once per frame
    void Update()
    {
        // 아무 키나 누르면
        if(Input.anyKeyDown)
        {
            //// 파일 안에 글쓰기
            //File.WriteAllText(Application.persistentDataPath + "/Test.txt", "내용");

            // 파일 안에 있는 글 가져오기
            print(File.ReadAllText(Application.persistentDataPath + "/Test.txt"));

            //// 파일 삭제
            //File.Delete(Application.persistentDataPath + "/Test.txt");

            //// Test 파일을 3번 복제
            //// 복제할 때 이미 같은 이름의 파일이 있으면 삭제하고 복제
            //for (int i = 0; i < 3; i++)
            //{
            //    if (File.Exists(Application.persistentDataPath + "/Test" + i + ".txt"))
            //    {
            //        File.Delete(Application.persistentDataPath + "/Test" + i + ".txt");
            //    }
            //    File.Copy(Application.persistentDataPath + "/Test.txt",
            //    Application.persistentDataPath + "/Test" + i + ".txt");
            //}

            //// 파일 복사
            //File.Copy(Application.persistentDataPath + "/Test.txt",
            //    Application.persistentDataPath + "/Test2.txt");
        }
    }
}
