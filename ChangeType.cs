using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeType : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // �÷� > ��Ʈ
        float numF = 1.5f;
        int numI = (int)numF;
        print(numI);

        // ��Ʈ > �÷� (�ս��� ��� �Ͻ������� ��ȯ ����)
        numF = (float)numI;
        print(numF);

        // �÷� > ���ڿ�
        string numS = numF.ToString();
        print(numS);

        // ��Ʈ > ���ڿ�
        numS = numI.ToString();

        // ���ڿ� > �÷�,��Ʈ
        numF = float.Parse(numS);
        numI = int.Parse(numS);

        // ���ڿ� > ��
        numS = "true";
        bool boolS = bool.Parse(numS);
        print(boolS);

        // �� > ���ڿ�
        numS = boolS.ToString();
        print(numS);

        //boolS = bool.Parse(numI); : �Ұ���
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
