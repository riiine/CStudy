using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 2.�ݺ����� �̿��Ͽ� �Ʒ��� ���� ��µǵ��� �ڵ� ����
// 12345
// 1234
// 123
// 12
// 1
public class Problem02 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string result = "";
        for (int i = 5; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                result += j;
            }
            result += "\n";
        }
        print(result);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
