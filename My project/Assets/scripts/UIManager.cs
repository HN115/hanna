using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    // ��ƴ� ���� ���� ���ϸ� �۷ι�(�ƹ������� ����)�̿��� ����?
    // ���� ����(local) ���� ����������
    // ���� ������, ������Ÿ�� �������ϱ�

    [HideInInspector] // �����Ϳ��� ����� ���� �� ��� // ������ �ϰ� ������ ���̺�� �����ϴ� �� ���ϴ�.
    public int testValue = 1;
   
    public Image bg; // bg��� ���� ������Ʈ �ϳ��� ������ ��.

    [SerializeField]
    Color _color; // �ʱⰪ�� (0,0,0,0)�̱⶧���� �������� �Ǿ�����

    bool isChanged; // boolŸ���� ó�� ���Ǹ� �ϸ� false��. ���� 1 ������ 0

    Sprite test_01; // �⺻���� �Ǿ� �ִ� �̹���

    [SerializeField]
    Sprite test_02; // ���� ��ų ��



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
