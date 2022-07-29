using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class String : MonoBehaviour
{
    public string memo = "�ȳ��ϼ��� ���� ���ϸ��Դϴ� �� ��Ź�ؿ�";

    // Start is called before the first frame update
    void Start()
    {
        // ���ڿ��� ���� = ������ ����
        print(memo.Length);

        // '��'�̶�� �ܾ ������ ����, ������ ����
        if (memo.Contains("��"))
        {
            print("����");
        }
        else
        {
            print("����");
        }

        // �� ��°�� �ִ��� (������ -1)
        print(memo.IndexOf("��"));

        // �� ����� (����� ����ǵ��� �ذ��غ���)
        memo = memo.Remove(9, 1); // 9������ 1�� ����

        // �߰��� �� �߰�
        memo = memo.Insert(6, "�ݰ����ϴ�"); // 6���� �� �߰�

        // �ڿ� �� �߰� (!)
        memo += "!";

        // �� �ٲٱ�
        memo = memo.Replace("��", "��");

        // ��Ӿ� *�� �ٲٱ�
        memo = memo.Replace("�ٺ�", "**");

        // ������ �����
        memo = memo.Replace("�ݰ����ϴ�.", "");

        // ù��° �丸 ������ �ٲٱ�
        int index = memo.IndexOf("��");
        memo = memo.Remove(index, 1);
        memo = memo.Insert(index, "��");

        // ���ڿ� > ���� �迭
        char[] charArray = memo.ToCharArray();
        foreach (var item in charArray)
        {
            print(item);
        }

        // ���ڿ� > ���ڿ� �迭 (���� ����)
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
