using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    // 루아는 따로 정의 안하면 글로벌(아무데서나 접근)이였음 ㅇㅇ?
    // 지역 변수(local) 따로 해줬을거임
    // 변수 여러개, 데이터타입 여러개니까

    [HideInInspector] // 에디터에서 숨기고 싶을 때 사용 // 여러개 하고 싶으면 테이블로 관리하는 게 편하다.
    public int testValue = 1;
   
    public Image bg; // bg라는 게임 오브젝트 하나를 저장한 것.

    [SerializeField]
    Color _color; // 초기값이 (0,0,0,0)이기때문에 검정으로 되어있음

    bool isChanged; // bool타입은 처음 정의만 하면 false다. 참은 1 거짓은 0

    Sprite test_01; // 기본으로 되어 있는 이미지

    [SerializeField]
    Sprite test_02; // 변경 시킬 것



    [SerializeField]
    TextMeshProUGUI _text;
    private void Start()
    {
        
        test_01 = bg.sprite;
      //  Debug.Log(testValue);
    }
    public void ChangeColor()
    {
        if (!isChanged)
        {


            bg.sprite = test_02;
            _text.text = "eeeeeeeeeeeeeeeeeeeeeee";
            // bg.color = Color.red;   
            isChanged =true;
        }

    else
        {
          
            bg.sprite = test_01;
            _text.text = "wwwwwwwwwwwwwwww";
            
            //  bg.color = _color;   
            isChanged=false;
    
        }    
        
    }
}
