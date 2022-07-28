using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class List : MonoBehaviour
{
    // ��Ʈ �ڷ����� ����Ʈ 
    public List<int> intList = new List<int>();

    public List<int> intList2 = new List<int>() { 1, 2 };

    // Start is called before the first frame update
    void Start()
    {
        List<float> floatList = new List<float>();
        List<string> stringList = new List<string>();
        List<bool> boolList = new List<bool>();

        // �� �߰�
        intList.Add(5);
        intList.Add(4);
        intList.Add(3);
        intList.Add(2);
        intList.Add(1);

        // �� ��ü
        intList[0] = 10;

        // ����Ʈ�� �ִ� ��� �� ��� - ���� + ����ġ��
        for(int i=0; i < intList.Count; i++)
        {
            print(intList[i]);
        }

        foreach(var item in intList)
        {
            print(item);
        }

        // �� ����
        intList.RemoveAt(4);
        intList.RemoveAt(3);

        // �߰��� �� �߰�
        intList.Insert(1, 20);

        // ����Ʈ > �迭
        int[] intArray = intList.ToArray();
        foreach (var item in intArray)
        {
            print(item);
        }

        // �迭 > ����Ʈ
        string[] stringArray = { "��", "��", "��", "��" };
        stringList = stringArray.ToList<string>();
        foreach(var item in stringList)
        {
            print(item);
        }

        // ����Ʈ �߰� (��ġ��)
        intList.AddRange(intList2);

        //intList2 = intList; // �̷��� �ϸ� �� ��. ������ ���� ���� �ٲ�

        // intList2�� intList�� ��� ���� �Ҵ��ϵ�, �������̰� �ϱ�
        intList2.Clear();
        intList2.AddRange(intList);
        //intList2 = intList.ToList(); // ���� �� ��
        //foreach(var item in intList)
        //{
        //    intList2.Add(item);
        //}

        // ����Ʈ �ȿ� �ִ��� ������
        print(intList.Contains(100));

        // �ε��� Ȯ��
        print(stringList.IndexOf("��"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
