using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 3. �����̽��ٸ� ���� ������ ������ ���� ����, �Ʒ��� ����ó�� ��� �̾������� ����ϱ�
// ù��°�� �����̽��ٸ� ������ 2
// �ι�°�� �����̽��ٸ� ������ 26
// ����°�� �����̽��ٸ� ������ 261
// ...
public class Problem03 : MonoBehaviour
{
    string result = "";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int random = Random.Range(0, 10);

            result += random.ToString();

            print(result);
        }
    }
}
