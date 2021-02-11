using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventActive : MonoBehaviour
{
    public GameObject window;
    public Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        
    }
    private void LateUpdate()
    {
        SetEvent();
    }
    void SetEvent()
    {
        if (Input.GetMouseButtonDown(0))
        {
            anim.speed = 1f;
            anim.Play("Event");
            Invoke("Hide", 0.45f);
        }

        if (Input.GetMouseButtonDown(1))
        {
            anim.speed = 1f;
            anim.Play("EventOut");
            Invoke("Show", 0.3f);
        }
    }
    
    void Stop()
    {
        anim.speed = 0f;
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
