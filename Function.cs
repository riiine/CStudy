using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Function : MonoBehaviour
{
    public string name;

    // [����������]
    // public : �ܺο��� ����� ����
    // private : �ܺο��� ����� �Ұ��� (��������)

    // Start is called before the first frame update
    void Start()
    {
        //float z = 0f;

        //Addition(1, 2, out z);

        //print(z);

        ////int test = Addition(1, 2);

        //Addition2(5);

        //print(System.DateTime.Now.ToString("yyyy"));

        //print(AgeCal(1994));

        print("��ŸƮ�Լ�");
    }

    void Update()
    {
        print("������Ʈ�Լ�");
    }

    // ���� ��� �Լ�
    int AgeCal(int birthYear)
    {
        // ����⵵ ���ؼ� ������ ����
        string nowYear = System.DateTime.Now.ToString("yyyy");

        // ����⵵ - ����⵵ ��ȯ
        return int.Parse(nowYear) - birthYear + 1;
    }

    public int Addition(int x)
    {
        return x + 1;
    }

    int Addition(int x, int y, out float z)
    {
        z = 3.5f;

        return x + y;
    }

    void Addition2(int x)
    {
        print(x + 1);
    }

    void Addition()
    {
        int x = 1;
        int y = 5;

        print(x + y);
    }

    // 1. �Ű����� : �Լ��� ȣ���� �� Ư�� ���� �����ֱ� ����
    // 2. ��ȯ�� : �Լ��� ������� �޾ƿ��� ����
    // 3. out, ref : �ݴ��(�θ��� ������� ������ �� = ��ȯ��)
}
