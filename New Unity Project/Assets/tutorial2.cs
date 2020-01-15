using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorial2 : MonoBehaviour
{
    void Update()
    {
        //Input : 마우스, 키보드 input을 관리하는 class
        //키보드
        if(Input.anyKeyDown){ // anyKeyDown아무키나 눌리면 true return  
            Debug.Log("키가 눌렸습니다.");
        }
        if(Input.anyKey){
            Debug.Log("키가 눌리고 있습니다. .");
        }
        if(Input.GetKeyDown(KeyCode.Return)){
            Debug.Log("아이템을 구입하였습니다.");
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            Debug.Log("왼쪽으로 이동 중 ");
        }
        if(Input.GetKeyUp(KeyCode.RightArrow)){
            Debug.Log("오른쪽 이동을 멈추었습니다.");
        }
        //마우스
         if(Input.GetMouseButtonDown(0)){
            Debug.Log("미사일 발사!");
        }
         if(Input.GetMouseButton(0)){
            Debug.Log("미사일 모으는 중...");
        }
         if(Input.GetMouseButtonUp(0)){
            Debug.Log("슈퍼 미사일 발사!");
        }
        //button
        if(Input.GetButtonDown("Jump")){
            Debug.Log("점프!");
        }
         if(Input.GetButton("Jump")){
            Debug.Log("추진력 모으는 중");
        }
         if(Input.GetButtonUp("Jump")){
            Debug.Log("슈퍼점프!");
        }
        //버튼 만드는거는 size에서 하나 늘려서 입력하면 새로 만들어짐. 내가 알아서 설정 넣기 
         if(Input.GetButton("Horizontal")){
            Debug.Log("횡 이동 중..."+Input.GetAxis("Horizontal"));//(GetAxis: 횡 축을 가져옴)/GetAxisRaw: 걍 1,0,-1만 나옴/Input.GetAxis("Horizontal")이거 결과는 float
        }
    }
}
