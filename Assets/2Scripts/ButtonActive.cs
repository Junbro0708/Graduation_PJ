using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonActive : MonoBehaviour
{
    public GameObject btn_E;
    public GameObject btn_F;

    public void HideBtn_E()
    {
        btn_E.SetActive(false);

        btn_F.SetActive(false);
    }

    public void AppendBtn_E()
    {
        btn_E.SetActive(true);

        btn_F.SetActive(false);
    }

    public void HideBtn_F()
    {
        btn_F.SetActive(false);

        btn_E.SetActive(false);
    }

    public void AppendBtn_F()
    {
        btn_F.SetActive(true);

        btn_E.SetActive(false);
    }

    public void OnClick_Btn_F()
    {
        SceneManager.LoadScene("Family_Event");
    }
}
