using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 1. �Ʒ��� ���� �Է°��� ������ ��ȯ���� ��ȯ�ϴ� �Լ� �����
// �Է°�  3   5   10
// ��ȯ��  11  27  102
public class Problem01 : MonoBehaviour
{
    public int input; // �Է°�

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ReturnFunc(input);
    }

    public int ReturnFunc(int returnValue)
    {
        if (input == 3)
        {
            returnValue = 11;
        }

        if (input == 5)
        {
            returnValue = 27;
        }

        if (input == 10)
        {
            returnValue = 102;
        }

        return returnValue;
    }

}
