using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
// 4. ���� ����Ʈ�� ����� ���ϴ� �� 5���� �ְ�, ���� ū ���� �� ��°�� �ִ��� ã�Ƽ� ���
public class Problem04 : MonoBehaviour
{
    public List<int> intList2 = new List<int>() { 1, 2, 3, 4, 5 };
    // Start is called before the first frame update
    void Start()
    {
        // ���� ū ��
        int max = intList2.Max();

        // �� ��°����?
        int p = intList2.IndexOf(max);

        // Ȯ��
        print(p);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
