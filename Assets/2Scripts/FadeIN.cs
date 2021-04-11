using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIN : MonoBehaviour
{
    public Image Panel;

    float time = 0f;
    float fade_T = 0.5f;

    bool isActiveL = false;
    bool isActiveR = false;

    void Update()
    {
        if (Input.GetButtonDown("House In") && !isActiveL && !isActiveR)
        {
            Fade();
        }
        if (Input.GetButtonDown("House Out") && isActiveL && isActiveR)
        {
            Fade();
        }
        if (Input.GetButtonDown("Enviroment In") && !isActiveL && !isActiveR)
        {
            Fade();
        }
        if (Input.GetButtonDown("Enviroment Out") && isActiveL && isActiveR)
        {
            Fade();
        }
        if (Input.GetButtonDown("Date In") && !isActiveL && !isActiveR)
        {
            Fade();
        }
        if (Input.GetButtonDown("Date Out") && isActiveL && isActiveR)
        {
            Fade();
        }
        if (Input.GetButtonDown("Suicide In") && !isActiveL && !isActiveR)
        {
            Fade();
        }
        if (Input.GetButtonDown("Suicide Out") && isActiveL && isActiveR)
        {
            Fade();
        }
    }

    public void Fade()
    {
        StartCoroutine(FadeFlow());
    }

    IEnumerator FadeFlow()
    {
        Panel.gameObject.SetActive(true);
        time = 0f;
        Color alpha = Panel.color;

        while(alpha.a < 1f)
        {
            time += Time.deltaTime / fade_T;
            alpha.a = Mathf.Lerp(0, 1, time);
            Panel.color = alpha;
            yield return null;
        }
        time = 0f;

        // yield return new WaitForSeconds(0f);

        while (alpha.a > 0f)
        {
            time += Time.deltaTime / fade_T;
            alpha.a = Mathf.Lerp(1, 0, time);
            Panel.color = alpha;
            yield return null;
        }

        Panel.gameObject.SetActive(false);
        yield return null;
    }

    void FIsActiveL()
    {
        isActiveL = true;
        Debug.Log(isActiveL);
    }
    void FIsNotActiveL()
    {
        isActiveL = false;
        Debug.Log(isActiveL);
    }

    void FIsActiveR()
    {
        isActiveR = true;
        Debug.Log(isActiveR);
    }
    void FIsNotActiveR()
    {
        isActiveR = false;
        Debug.Log(isActiveR);
    }
}
