using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventActive : MonoBehaviour
{
    public GameObject window;
    public GameObject enviroment;
    Animator anim;
    bool isActiveL = false;
    bool isActiveR = false;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void LateUpdate() // 카메라 애니메이션은 LateUpdate()에 만들어야해서 여기다 만들었어
    {
        SetEvent(); // 이게 카메라 이동 메인 함수
    }

    void SetEvent()
    {
        if (Input.GetButtonDown("House In") && !isActiveL && !isActiveR) // 가정 폭력은 1-2
        {
            anim.speed = 1f; 
            anim.Play("HouseEvent");
            Invoke("Hide", 0.45f); // 창문이 바로 사라지면 살짝 어색해서 딜레이 줬어 
        }

        if (Input.GetButtonDown("House Out") && isActiveL && isActiveR) // 우클릭을 하면 돌아오는 애니메이션 구현 (예외 처리로 좌클릭을 누를경우 방지시켰는데 예외처리 한번 더 해야함. 그건 이벤트 구현 뒤에)
        {
            anim.speed = 1f;
            anim.Play("HouseEventOut");
            Invoke("Show", 0.11f);
        }

        if (Input.GetButtonDown("Enviroment In") && !isActiveL && !isActiveR) // 환경 문제는 3-4
        {
            anim.speed = 1f;
            anim.Play("EnviromentEvent");
            Invoke("ShowE", 0.45f); 
        }

        if (Input.GetButtonDown("Enviroment Out") && isActiveL && isActiveR) 
        {
            anim.speed = 1f;
            anim.Play("EnviromentEventOut");
            Invoke("HideE", 0.05f);
        }

        if (Input.GetButtonDown("Date In") && !isActiveL && !isActiveR) // 데이트 폭력 문제는 5-6
        {
            anim.speed = 1f;
            anim.Play("DateEvent");
            //Invoke("ShowE", 0.45f);
        }

        if (Input.GetButtonDown("Date Out") && isActiveL && isActiveR)
        {
            anim.speed = 1f;
            anim.Play("DateEventOut");
            //Invoke("HideE", 0.05f);
        }

        if (Input.GetButtonDown("Suicide In") && !isActiveL && !isActiveR) // 자살 문제는 7-8
        {
            anim.speed = 1f;
            anim.Play("SuicideEvent");
            //Invoke("ShowE", 0.45f);
        }

        if (Input.GetButtonDown("Suicide Out") && isActiveL && isActiveR)
        {
            anim.speed = 1f;
            anim.Play("SuicideEventOut");
            //Invoke("HideE", 0.05f);
        }
    }

    void Hide()
    {
        window.SetActive(false);
    }
    void Show()
    {
        window.SetActive(true);
    }
    void HideE()
    {
        enviroment.SetActive(false);
    }
    void ShowE()
    {
        enviroment.SetActive(true);
    }

    void Stop() // 이 함수는 애니메이션 특정 프레임에서 함수가 실행되게끔 만들었어 유니티 애니메이터 창에 설정 되어있어
    {
        anim.speed = 0f; // 애니메이션이 끝나면 맨 처음 위치로 돌아와서 그거 방지하려고 속도 0으로 해서 끝에 남아있게 만들었어
    }
    void IsActiveL()
    {
        isActiveL = true;
        Debug.Log(isActiveL);
    }
    void IsNotActiveL()
    {
        isActiveL = false;
        Debug.Log(isActiveL);
    }

    void IsActiveR()
    {
        isActiveR = true;
        Debug.Log(isActiveR);
    }
    void IsNotActiveR()
    {
        isActiveR = false;
        Debug.Log(isActiveR);
    }
}
