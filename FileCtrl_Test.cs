using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO; // ���� �����

public class FileCtrl_Test : MonoBehaviour
{
    // 1. ü���� ��Ÿ���� hp ���� �����, �ν����� â���� ���̰�
    public int hp;

    // Start is called before the first frame update
    void Start()
    {
        // 3. ������ ���۵� ��, ��ġ�� ����Ǿ� �ִ� ü���� �ִٸ�
        // �����ͼ� hp ������ �Ҵ�
        if (File.Exists(@"C:\Users\D\Desktop\Test.txt"))
        {
            hp = int.Parse(File.ReadAllText(@"C:\Users\D\Desktop\Test.txt"));
        }
    }

    // Update is called once per frame
    void Update()
    {
        // 2. �ƹ�Ű�� ������ ��, ���ϴ� ��ġ�� �޸��� �����,
        // �� �ȿ� hp ������ �ִ� �� ����
        if (Input.anyKeyDown)
        {
            File.WriteAllText(@"C:\Users\D\Desktop\Test.txt", hp.ToString());
        }
    }
}
