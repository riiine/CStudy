using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
// 4. 정수 리스트를 만들어 원하는 값 5개를 넣고, 가장 큰 값이 몇 번째에 있는지 찾아서 출력
public class Problem04 : MonoBehaviour
{
    public List<int> intList2 = new List<int>() { 1, 2, 3, 4, 5 };
    // Start is called before the first frame update
    void Start()
    {
        // 가장 큰 값
        int max = intList2.Max();

        // 몇 번째인지?
        int p = intList2.IndexOf(max);

        // 확인
        print(p);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
