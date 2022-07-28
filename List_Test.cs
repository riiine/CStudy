using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class List_Test : MonoBehaviour
{
    // 1. ��Ʈ �ڷ������� �迭�� ���� �ȿ� ���ϴ� �� 5�� �̻� �ֱ�
    public int[] intArray2 = { 1, 2, 3, 4, 80 };

    // 2. ���ο� ����Ʈ ����
    public List<int> intList = new List<int>();

    // Start is called before the first frame update
    void Start()
    {
        // 3. 1������ ���� �迭�� 2������ ���� ����Ʈ�� �ֱ�
        intList = intArray2.ToList<int>();

        foreach (var item in intList)
        {
            print(item);
        }

        // 4. ����Ʈ �ȿ� 80�̶�� ���� �ִ��� Ȯ���ϰ�, �ִٸ� �� ��°�� �ִ��� ��ȣ ���
        if (intList.Contains(80)) 
        {
            print(intList.IndexOf(80));
        }
        else
        {
            print("���� �����ϴ�.");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
