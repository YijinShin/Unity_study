using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//unity lifecycle
public class tutorial1 : MonoBehaviour
{   
    //초기화 영역 
    void Awake(){//첫번째 사이클 
        Debug.Log("플레이어 데이터가 준비되었습니다.");
    }
    void OnEnable(){//오브젝트 활성화 영역(만약 오브젝트가 활성화 비활성화 설정이 가능한 오브젝트라면 사용하고, 그렇지 않으면 사용 안해도됨 )
        Debug.Log("플레이어 로그인했습니다..");
    }
    void Start(){//Update 시작 전 최초 실행 되는 사이클 
        Debug.Log("장비를 챙겼습니다.");
    }
   
    //물리 연산 영역
    void FixedUpdate(){//물리 연산 업데이트
        //얘는 1초에 50번 가량 돈다. 컴퓨터 사양에는 영향 안받음
        Debug.Log("이동");
    }
    //게임 로직 영역
    void Update(){//게임 로직 업데이트
        //얘는 1초에 60번 가량 돈다. 사양에 따라 영향 받음 
        Debug.Log("몬스터 사냥");
    }
    void LateUpdate(){//모든 업데이트 끝난 후 실행됨(Update와 거의 같이 실행) 
        //보통 캐릭터를 따라가는 카메라나 후처리 
        Debug.Log("경험치 획득.");
    }
    void onDisable(){//게임 오브젝트가 비활성화 되었을 때
        Debug.Log("플레이어가 로그아웃했습니다.");
    }

    //해체 영역(무조건 돌아가는거 아니고 특정 경우에만 사용하는 것 캐삭이라던가)
    void OnDestroy(){//게임 오브젝트가 삭제될 때
        // 오브젝트가 삭제되기 직전에 무언가 남기고 삭제된다는 것
        Debug.Log("플레이어 데이터를 해제하였습니다.");
    }
}
