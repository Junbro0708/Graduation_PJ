using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RageBar : MonoBehaviour
{
    public Image one;
    public Image two;
    public Image three;
    public Image four;
    public Image five;
    public Image six;
    public Image seven;
    public Image eight;
    public Image nine;
    public Image ten; // 이거는 게이지 블록들

    public GameObject Anger1;
    public GameObject Anger2;
    public GameObject Anger3; // 이거는 여자친구 화남 표시등

    float gage = 0f; // 압력 센서 값을 여기에다가 넣으면 돼!

    private void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)) // 이거는 위 화살표 누르면 값을 넣은건데 압력센서 이용하면 삭제해도됌
        {
            gage += Time.deltaTime;
        }
        else
        {
            gage -= Time.deltaTime; // 아무런 압력이 없으면 서서히 사라지게 만들었어
        }

        if(gage < 0)
        {
            gage = 0; // 그리고 게이지가 0이면 그대로 계속 0으로 만들었움.
        }else if(gage > 10)
        {
            SceneManager.LoadScene("MainScene"); // 게이지가 도달하면 메인씬으로 이동하는건데 나중에 수정해야지
        }

        ActiveBar(); // 이건 압력센서 값에따라 블록이 올라갔다 내려가는거 구현했어 + 여자친구 화남 표시등까지
    }

    void ActiveBar()
    {
        if(gage < 1 && gage > 0)
        {
            one.gameObject.SetActive(true);
            two.gameObject.SetActive(false);
            three.gameObject.SetActive(false);
            four.gameObject.SetActive(false);
            five.gameObject.SetActive(false);
            six.gameObject.SetActive(false);
            seven.gameObject.SetActive(false);
            eight.gameObject.SetActive(false);
            nine.gameObject.SetActive(false);
            ten.gameObject.SetActive(false);

            Anger1.SetActive(false);
            Anger2.SetActive(false);
            Anger3.SetActive(false);
        }
        else if(gage < 2 && gage > 1)
        {
            one.gameObject.SetActive(true);
            two.gameObject.SetActive(true);
            three.gameObject.SetActive(false);
            four.gameObject.SetActive(false);
            five.gameObject.SetActive(false);
            six.gameObject.SetActive(false);
            seven.gameObject.SetActive(false);
            eight.gameObject.SetActive(false);
            nine.gameObject.SetActive(false);
            ten.gameObject.SetActive(false);

            Anger1.SetActive(false);
            Anger2.SetActive(false);
            Anger3.SetActive(false);
        }
        else if (gage < 3 && gage > 2)
        {
            one.gameObject.SetActive(true);
            two.gameObject.SetActive(true);
            three.gameObject.SetActive(true);
            four.gameObject.SetActive(false);
            five.gameObject.SetActive(false);
            six.gameObject.SetActive(false);
            seven.gameObject.SetActive(false);
            eight.gameObject.SetActive(false);
            nine.gameObject.SetActive(false);
            ten.gameObject.SetActive(false);

            Anger1.SetActive(true);
            Anger2.SetActive(false);
            Anger3.SetActive(false);
        }
        else if (gage < 4 && gage > 3)
        {
            one.gameObject.SetActive(true);
            two.gameObject.SetActive(true);
            three.gameObject.SetActive(true);
            four.gameObject.SetActive(true);
            five.gameObject.SetActive(false);
            six.gameObject.SetActive(false);
            seven.gameObject.SetActive(false);
            eight.gameObject.SetActive(false);
            nine.gameObject.SetActive(false);
            ten.gameObject.SetActive(false);

            Anger1.SetActive(true);
            Anger2.SetActive(false);
            Anger3.SetActive(false);
        }
        else if (gage < 5 && gage > 4)
        {
            one.gameObject.SetActive(true);
            two.gameObject.SetActive(true);
            three.gameObject.SetActive(true);
            four.gameObject.SetActive(true);
            five.gameObject.SetActive(true);
            six.gameObject.SetActive(false);
            seven.gameObject.SetActive(false);
            eight.gameObject.SetActive(false);
            nine.gameObject.SetActive(false);
            ten.gameObject.SetActive(false);

            Anger1.SetActive(true);
            Anger2.SetActive(false);
            Anger3.SetActive(false);
        }
        else if (gage < 6 && gage > 5)
        {
            one.gameObject.SetActive(true);
            two.gameObject.SetActive(true);
            three.gameObject.SetActive(true);
            four.gameObject.SetActive(true);
            five.gameObject.SetActive(true);
            six.gameObject.SetActive(true);
            seven.gameObject.SetActive(false);
            eight.gameObject.SetActive(false);
            nine.gameObject.SetActive(false);
            ten.gameObject.SetActive(false);

            Anger1.SetActive(true);
            Anger2.SetActive(true);
            Anger3.SetActive(false);
        }
        else if (gage < 7 && gage > 6)
        {
            one.gameObject.SetActive(true);
            two.gameObject.SetActive(true);
            three.gameObject.SetActive(true);
            four.gameObject.SetActive(true);
            five.gameObject.SetActive(true);
            six.gameObject.SetActive(true);
            seven.gameObject.SetActive(true);
            eight.gameObject.SetActive(false);
            nine.gameObject.SetActive(false);
            ten.gameObject.SetActive(false);

            Anger1.SetActive(true);
            Anger2.SetActive(true);
            Anger3.SetActive(false);
        }
        else if (gage < 8 && gage > 7)
        {
            one.gameObject.SetActive(true);
            two.gameObject.SetActive(true);
            three.gameObject.SetActive(true);
            four.gameObject.SetActive(true);
            five.gameObject.SetActive(true);
            six.gameObject.SetActive(true);
            seven.gameObject.SetActive(true);
            eight.gameObject.SetActive(true);
            nine.gameObject.SetActive(false);
            ten.gameObject.SetActive(false);

            Anger1.SetActive(true);
            Anger2.SetActive(true);
            Anger3.SetActive(false);
        }
        else if (gage < 9 && gage > 8)
        {
            one.gameObject.SetActive(true);
            two.gameObject.SetActive(true);
            three.gameObject.SetActive(true);
            four.gameObject.SetActive(true);
            five.gameObject.SetActive(true);
            six.gameObject.SetActive(true);
            seven.gameObject.SetActive(true);
            eight.gameObject.SetActive(true);
            nine.gameObject.SetActive(true);
            ten.gameObject.SetActive(false);

            Anger1.SetActive(true);
            Anger2.SetActive(true);
            Anger3.SetActive(true);
        }
        else if(gage > 9)
        {
            one.gameObject.SetActive(true);
            two.gameObject.SetActive(true);
            three.gameObject.SetActive(true);
            four.gameObject.SetActive(true);
            five.gameObject.SetActive(true);
            six.gameObject.SetActive(true);
            seven.gameObject.SetActive(true);
            eight.gameObject.SetActive(true);
            nine.gameObject.SetActive(true);
            ten.gameObject.SetActive(true);

            Anger1.SetActive(true);
            Anger2.SetActive(true);
            Anger3.SetActive(true);
        }
    }
}
