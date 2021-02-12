using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventActive : MonoBehaviour
{
    public GameObject window;
    Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        
    }

    private void LateUpdate() // 카메라 애니메이션은 LateUpdate()에 만들어야해서 여기다 만들었어
    {
        SetEvent(); // 이게 카메라 이동 메인 함수
    }

    void SetEvent()
    {
        if (Input.GetMouseButtonDown(0)) // 좌클릭을 하면 들어가는 애니메이션 구현
        {
            anim.speed = 1f; 
            anim.Play("Event");
            Invoke("Hide", 0.45f); // 창문이 바로 사라지면 살짝 어색해서 딜레이 줬어 
        }

        if (Input.GetMouseButtonDown(1)) // 우클릭을 하면 돌아오는 애니메이션 구현
        {
            anim.speed = 1f;
            anim.Play("EventOut");
            Invoke("Show", 0.3f);
        }
    }
    
    void Stop() // 이 함수는 애니메이션 특정 프레임에서 함수가 실행되게끔 만들었어 유니티 애니메이터 창에 설정 되어있어
    {
        anim.speed = 0f; // 애니메이션이 끝나면 맨 처음 위치로 돌아와서 그거 방지하려고 속도 0으로 해서 끝에 남아있게 만들었어
    }
    void Hide()
    {
        window.SetActive(false); 
    }
    void Show()
    {
        window.SetActive(true);
    }
}
