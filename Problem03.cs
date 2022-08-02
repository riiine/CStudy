using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 3. 스페이스바를 누를 때마다 랜덤한 수를 고르고, 아래의 예시처럼 계속 이어지도록 출력하기
// 첫번째로 스페이스바를 누르면 2
// 두번째로 스페이스바를 누르면 26
// 세번째로 스페이스바를 누르면 261
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
