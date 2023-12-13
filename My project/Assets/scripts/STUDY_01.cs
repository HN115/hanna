using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class STUDY_01 : MonoBehaviour
{

    /* 옆으로 움직이는 횡스크롤 게임의 배경 움직이는 원리 
    ----------------------------------------------------------
    //public float moveSpeed;

    //    float startPosX = 10f;
    //    float endPosY = 10f;

    // Time.deltaTime -> 프레임당 초 그냥 컴퓨터별로 성능 달라도 동일한 시간차이를 주는 거
    -----------------------------------------------------------------*/


    // Start is called before the first frame update
    // 시작 첫 프레임에 실행이 된다.

    int test;

    // lua = nil
    // C# = null

    void Awake() // 얘가 스타트보다 빨리 1회 실행 // 교수님은 잘 안쓰심
    {
        Debug.LogError(test);
    }



    void Start()
    {
        Debug.Log("Start");
        /*Debug.Log(test);
        test++;
        Debug.Log(test);
        test += 1;
        Debug.Log(test);
        test = test + 1;
        Debug.Log(test);*/

        // 위 세 개는 같은 말이다.
        // for 문이나 반복문 또는 강화 레벨이 올라갈 때 쓸 수 있다.

    }

    void OnDestroy()
    {
        Debug.Log("으악! 범인은 박민수......");  
    }
    //void FixedUpdate()
    //{
    //    Debug.LogWarning("FixedUpdate");

    //}

   


    void OnEnable() // 이 스크립트를 가진 (컴포넌트로 달린)
                    // 오브젝트가 활성화 될때
    {
        Debug.Log("켜졌다.");

    }

    void OnDisable()
    {
        Debug.Log("꺼졌다.");

    }

    // Update is called once per frame
    // 매 프레임마다 부른다.
    void Update()
    {
        Debug.Log("Update");
        
    }

    //void LateUpdate()
    //{
    //    Debug.LogError("LateUpdate");
        
    //}


}
