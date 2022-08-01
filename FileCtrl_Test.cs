using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO; // 파일 입출력

public class FileCtrl_Test : MonoBehaviour
{
    // 1. 체력을 나타내는 hp 변수 만들기, 인스펙터 창에서 보이게
    public int hp;

    // Start is called before the first frame update
    void Start()
    {
        // 3. 게임이 시작될 때, 위치에 저장되어 있는 체력이 있다면
        // 가져와서 hp 변수에 할당
        if (File.Exists(@"C:\Users\D\Desktop\Test.txt"))
        {
            hp = int.Parse(File.ReadAllText(@"C:\Users\D\Desktop\Test.txt"));
        }
    }

    // Update is called once per frame
    void Update()
    {
        // 2. 아무키나 눌렀을 때, 원하는 위치에 메모장 만들고,
        // 그 안에 hp 변수에 있는 값 적기
        if (Input.anyKeyDown)
        {
            File.WriteAllText(@"C:\Users\D\Desktop\Test.txt", hp.ToString());
        }
    }
}
