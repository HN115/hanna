using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class STUDY_01 : MonoBehaviour
{

    /* ������ �����̴� Ⱦ��ũ�� ������ ��� �����̴� ���� 
    ----------------------------------------------------------
    //public float moveSpeed;

    //    float startPosX = 10f;
    //    float endPosY = 10f;

    // Time.deltaTime -> �����Ӵ� �� �׳� ��ǻ�ͺ��� ���� �޶� ������ �ð����̸� �ִ� ��
    -----------------------------------------------------------------*/


    // Start is called before the first frame update
    // ���� ù �����ӿ� ������ �ȴ�.

    int test;

    // lua = nil
    // C# = null

    void Awake() // �갡 ��ŸƮ���� ���� 1ȸ ���� // �������� �� �Ⱦ���
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

        // �� �� ���� ���� ���̴�.
        // for ���̳� �ݺ��� �Ǵ� ��ȭ ������ �ö� �� �� �� �ִ�.

    }

    void OnDestroy()
    {
        Debug.Log("����! ������ �ڹμ�......");  
    }
    //void FixedUpdate()
    //{
    //    Debug.LogWarning("FixedUpdate");

    //}

   


    void OnEnable() // �� ��ũ��Ʈ�� ���� (������Ʈ�� �޸�)
                    // ������Ʈ�� Ȱ��ȭ �ɶ�
    {
        Debug.Log("������.");

    }

    void OnDisable()
    {
        Debug.Log("������.");

    }

    // Update is called once per frame
    // �� �����Ӹ��� �θ���.
    void Update()
    {
        Debug.Log("Update");
        
    }

    //void LateUpdate()
    //{
    //    Debug.LogError("LateUpdate");
        
    //}


}
