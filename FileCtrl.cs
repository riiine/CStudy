using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO; // ���� �����

public class FileCtrl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // �⺻������ �����ϱ� ���� ���
        print(Application.persistentDataPath);

        // �⺻������ �����ϱ� ���� ��ο� ���� ����
        // 1. ��� ��������
        // 2. � �̸����� ��������
        // 3. � Ÿ������ ��������
        File.Create(Application.persistentDataPath + "/Test.txt");
        // ���� �̸��� ������ �����ϸ� �����

        File.Create(@"C:\Users\D\Desktop\Test.txt");

        // ������ ��� or ��������+@
    }

    // Update is called once per frame
    void Update()
    {
        // �ƹ� Ű�� ������
        if(Input.anyKeyDown)
        {
            //// ���� �ȿ� �۾���
            //File.WriteAllText(Application.persistentDataPath + "/Test.txt", "����");

            // ���� �ȿ� �ִ� �� ��������
            print(File.ReadAllText(Application.persistentDataPath + "/Test.txt"));

            //// ���� ����
            //File.Delete(Application.persistentDataPath + "/Test.txt");

            //// Test ������ 3�� ����
            //// ������ �� �̹� ���� �̸��� ������ ������ �����ϰ� ����
            //for (int i = 0; i < 3; i++)
            //{
            //    if (File.Exists(Application.persistentDataPath + "/Test" + i + ".txt"))
            //    {
            //        File.Delete(Application.persistentDataPath + "/Test" + i + ".txt");
            //    }
            //    File.Copy(Application.persistentDataPath + "/Test.txt",
            //    Application.persistentDataPath + "/Test" + i + ".txt");
            //}

            //// ���� ����
            //File.Copy(Application.persistentDataPath + "/Test.txt",
            //    Application.persistentDataPath + "/Test2.txt");
        }
    }
}
