using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipsCtrl : MonoBehaviour
{

    public static TipsCtrl instance;

    public GameObject longGo;
    public GameObject huaGo;

    // Use this for initialization
    void Awake()
    {
        instance = this;
    }

    public void ShowTips(string name)
    {
        if (name == "long")
        {
            longGo.SetActive(true);
        }
        else if (name == "hua")
        {
            huaGo.SetActive(true);
        }
        Invoke("HideTips", 3.5f);
    }

    public void HideTips()
    {
        longGo.SetActive(false);
        huaGo.SetActive(false);
    }
}
