using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{        
    // ù ��° ��� : ���� �����鼭 ���� ũ�� ����
    // ��Ʈ �迭 ����
    public int[] intArray = { 1, 2, 3 };

    // Start is called before the first frame update
    void Start()
    {
        // �÷� �迭 ����
        float[] floatArray = { 0.1f, 2.3f, 5f };

        // ��Ʈ�� �迭 ����
        string[] stringArray = { "�ȳ�", "�ϼ���", "������" };

        // �� �迭 ����
        bool[] boolArray = { true, false, 1 < 2 };

        // ��Ʈ����� �� ���� ��� (����Ʈ �ڵ� �� ���� �ۼ�, ���ڿ� ����x)
        for (int i=0; i < stringArray.Length; i++) 
        {
            print(stringArray[i]);
        }

        // ��Ʈ����� �� ���� ���
        foreach (var item in stringArray)
        {
            print(item); // get
            //item = "o"; // set
        }
        // ���� : �÷��ǿ� ����ϱ� ���ϴ�
        // ���� : �ݺ� ������ �б� ���� (�Ҵ�X)

        floatArray[0] = 1.1f;

        foreach (var item in floatArray)
        {
            print(item);
        }

        // �� ��° ��� : ������ ũ�⸸ ���� (�ʱⰪ�� ��)
        int[] intArray2;
        intArray2 = new int[2];

        foreach (var item in intArray2)
        {
            print(item);
        }

        // 2���� �迭
        int[,] intArray3 = {
            { 1, 2, 3, 4, 5, 6},
            { 7, 8, 9, 10, 11, 12}
        };

        print(intArray3[1, 4]);

        // intArray3�� �ִ� ��� �� ���, foreach�� ����
        for (int i = 0; i < intArray3.GetLength(0); i++)
        {
            for (int j = 0; j < intArray3.GetLength(1); j++) 
            {
                print(intArray3[i, j]);
            }
        }

        int[,,] intArray4 = new int[2, 4, 3];

        // ���� �迭
        int[][] intArray5 = new int[3][];
        intArray5[0] = new int[6] { 1, 2, 3, 4, 5, 6 };
        intArray5[1] = new int[3];
        intArray5[2] = new int[5];

        int[][][] intArray6 = new int[3][][];
        intArray6[0] = new int[6][];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
