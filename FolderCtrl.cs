using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO; // 폴더 입출력
using System;

public class FolderCtrl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 폴더 생성
        Directory.CreateDirectory(@"C:\TestFolder");
    }

    

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            //Directory.GetFiles(@"C:\TestFolder");

            // 폴더 속 파일 전부 삭제한 후 폴더 삭제
            // 강사님 답
            // 폴더 속에 있는 모든 파일 가져오기
            string[] files = Directory.GetFiles(@"C:\TestFolder");
            //Directory.GetDirectories

            // 모든 파일 삭제
            foreach (var item in files)
            {
                File.Delete(item);
                //Directory.Delete
            }

            // 폴더 삭제
            Directory.Delete(@"C:\TestFolder", true);

            // 내가 쓴 답
            string path = @"C:\TestFolder";
            foreach (string directory in Directory.GetDirectories(path))
            {
                try
                {
                    Directory.Delete(directory, true);
                }
                catch (IOException)
                {
                    Directory.Delete(directory, true);
                }
                catch (UnauthorizedAccessException)
                {
                    Directory.Delete(directory, true);
                }
            }
            try
            {
                Directory.Delete(path, true);
            }
            catch (IOException)
            {
                Directory.Delete(path, true);
            }
            catch (UnauthorizedAccessException)
            {
                Directory.Delete(path, true);
            }
        }
    }
}
