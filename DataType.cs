using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataType : MonoBehaviour
{
    // �ʵ�
    float speed; // ���� ����

    string myName = "������";

    // Start is called before the first frame update
    void Start()
    {
        print(48 % 2); // ���� 0 1 2 100 -4 (int)

        print(1 / 10.0f); // �Ǽ� (float)

        print('��'); // ���� (char)

        print("�ȳ�" + "�ϼ���" + (3 + 3)); // ���ڿ� (string) : ����>�̾���̱�

        print(!(1 < 3)); // �� (bool) : ��(true)�� ����(false)

        speed = 0; // �Ҵ�

        int hp = 100; // ���� ���� + �Ҵ�

        speed = 10;

        print(speed);

        int S2peed2 = 1;

        /*
        [�ĺ��� ���� �� ��Ģ]
        1. Ű����� ����� �� ���� (Ű���� : �̹� �ǹ̸� ���� �ִ� �ܾ�)
        2. ����,Ư������ ��� �Ұ� (��, �����(_)�� ��� ����)
        3. ���ڷ� �����ϸ� �� ��

        [�����ڵ鳢���� ���]
        1. ������ �ҹ��ڷ� ����, �Լ�/Ŭ������ �빮�ڷ� ����
        2. �ǹ̾��� �ܾ� ����, ���� ������ �ǹ��ִ� �̸�
        3. �����ܾ�� �̷���� ���, �� �ܾ��� ù���ڸ� �빮�ڷ� �Ѵ�
         */

        int a = 10;
        float b = 2.5f;

        print("a + b");

        // ���� ���� ������
        a += 5;
        a -= 3;
        a *= 10;
        a /= 2;
        print(a);

        string c = "�ȳ�";
        c += "�ϼ���";
        print(c);

        // ���� ������
        int d = 10;
        print(d++); // ���� : ���� �ٷ� �Ѿ �� ����
        print(d--);

        print(++d); // ���� : �̹� �ٿ��� �ٷ� ����
        print(--d);

        // 10
        print(d++); // 10
        print(++d); // 12
        print(d--); // 12
        print(--d); // 10

        int e = 2;
        e += 1;
        e *= 2;
        e--;
        --e;
        print(e++);
        print(e);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
