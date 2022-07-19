using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardVSMouse : MonoBehaviour
{
    // ���콺 Ŭ�� Ƚ��
    public int mouseCount;

    // Ű���� Ŭ�� Ƚ��
    public int keyboardCount = 0;

    // ��� ������ ����
    string result = "";

    // ������ ��������
    public bool isEnd;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 0 : ��Ŭ��, 1 : ��Ŭ��, 2 : ��Ŭ��

        //// ��Ŭ���� �ϰ� �ִ� ��
        //if (Input.GetMouseButton(0))
        //{
        //    print("��Ŭ�� �ϴ� ��");
        //}

        //// ��Ŭ�� ���� ��
        //if (Input.GetMouseButtonUp(2))
        //{
        //    print("��Ŭ�� ���� ��");
        //}

        // ������ ����ƴٸ�
        if (isEnd)
        {
            return;
        }

        // ��Ŭ���� �� ����
        if (Input.GetMouseButtonDown(0))
        {
            // ���콺 Ŭ�� Ƚ�� ����
            mouseCount++;
        }

        // �����̹ٸ� ���� ����
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Ű���� ���� Ƚ�� ����
            keyboardCount++;
        }

        // �� �߿� �ϳ��� 10�� �Ǹ�
        if (mouseCount == 10 || keyboardCount == 10)
        {
            // ���� ����
            isEnd = true;

            // ���콺�� �̰�ٸ�
            if (mouseCount > keyboardCount)
            {
                result = "���콺 ��";
            }
            // Ű���尡 �̰�ٸ�
            else if (mouseCount < keyboardCount)
            {
                result = "Ű���� ��";
            }
            // ���º�
            else
            {
                result = "���º�";
            }

            // ���� ����! ���콺 : 0��, Ű���� : 0��, ��� : ~
            //print("���� ����! ���콺 : " + mouseCount + "��, "
            //    + "Ű���� : " + keyboardCount + "��, ��� : " + result);
            print($"���� ����! ���콺 : {mouseCount}��, Ű���� : {keyboardCount}��, ��� : {result}");
        }
    }
}
