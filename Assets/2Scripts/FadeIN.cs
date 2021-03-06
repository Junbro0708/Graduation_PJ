using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIN : MonoBehaviour
{
    public Image Panel;

    float time = 0f;
    float fade_T = 0.5f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            Fade();
        }
        if (Input.GetMouseButtonDown(1))
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
}
