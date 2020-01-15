using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void Start()
    {
        Debug.Log("hello unity");
        
        //그룹형 변수 
        string[] monsters = {"슬라임","머쉬맘","주벗"};
        //제네릭 변수
        List<string> items = new List<string>();
        items.Add("엘릭서30");
        Debug.Log(items[0]);
        items.RemoveAt(0);
    
        Debug.Log(" "+"입니다."); //+사용 가능 

        //bool 사용 예시
        bool isFullLevel = false;
        int FullLevel = 99;
        int level = 5;
        isFullLevel = level == FullLevel;
        Debug.Log("만랩인가?"+isFullLevel);



    }

}
