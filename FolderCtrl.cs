using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO; // ���� �����
using System;

public class FolderCtrl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // ���� ����
        Directory.CreateDirectory(@"C:\TestFolder");
    }

    

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            //Directory.GetFiles(@"C:\TestFolder");

            // ���� �� ���� ���� ������ �� ���� ����
            // ����� ��
            // ���� �ӿ� �ִ� ��� ���� ��������
            string[] files = Directory.GetFiles(@"C:\TestFolder");
            //Directory.GetDirectories

            // ��� ���� ����
            foreach (var item in files)
            {
                File.Delete(item);
                //Directory.Delete
            }

            // ���� ����
            Directory.Delete(@"C:\TestFolder", true);

            // ���� �� ��
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
