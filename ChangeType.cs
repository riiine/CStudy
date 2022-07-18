/** 2022.07.17 복습완료 */



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeType : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 플롯 > 인트
        float numF = 1.5f;
        int numI = (int)numF;
        print(numI);

        // 인트 > 플롯 (손실이 없어서 암시적으로 변환 가능)
        numF = (float)numI;
        print(numF);

        // 플롯 > 문자열
        string numS = numF.ToString();
        print(numS);

        // 인트 > 문자열
        numS = numI.ToString();

        // 문자열 > 플롯,인트
        numF = float.Parse(numS);
        numI = int.Parse(numS);

        // 문자열 > 불
        numS = "true";
        bool boolS = bool.Parse(numS);
        print(boolS);

        // 불 > 문자열
        numS = boolS.ToString();
        print(numS);

        //boolS = bool.Parse(numI); : 불가능
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
