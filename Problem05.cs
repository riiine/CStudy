using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO; // ���� �����
// 5. ��Ŭ������ �� ó���̶�� ����ȭ�鿡
// ���ο� ������ �� �ȿ� ���ο� �ؽ�Ʈ ������ �����ϰ�,
// ó���� �ƴ϶�� �ߺ� ���� ������ �̷����
// 5�ڸ� ���� ����� �ؽ�Ʈ ���� �ȿ� �Է��ϱ�
//(��, 5�ڸ� ���� 0���� ������ �� ����.) (*���� : ������ ��)
public class Problem05 : MonoBehaviour
{
    int count = 0;
    string numStr = ""; //������ ����� ����
    
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (count == 0) // ó���̶��
            {
                // ���� ����
                Directory.CreateDirectory(@"C:\Users\D\Desktop\TestFolder");
                // �ؽ�Ʈ ���� ����
                File.Create(@"C:\Users\D\Desktop\TestFolder\Test.txt");
                count++;
            }
            else // ó���� �ƴ϶��
            {
                int random = Random.Range(1, 10);
                string ran = random.ToString();

                if (!numStr.Contains(ran)) 
                {
                    numStr += ran;

                    // ���� �ȿ� �۾���
                    File.WriteAllText(@"C:\Users\D\Desktop\TestFolder\Test.txt", numStr);
                }
            }
            
        }
    }
}
