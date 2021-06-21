using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StratUIManger : MonoBehaviour {

    public GameObject que1Panel;
    public GameObject que2Panel;

    public GameObject wrong1Panel;
    public GameObject wrong2Panel;
    public GameObject endRightPanel;

    public void OnClickStratQue()
    {
        que1Panel.SetActive(true);
    }

    public void OnClickStartGame()
    {
        Application.LoadLevel(1);
    }

    public void OnClickLuButton()
    {
        que1Panel.SetActive(false);
        wrong1Panel.SetActive(true);
    }

    public void OnClickWrong1Back()
    {
        wrong1Panel.SetActive(false);
        que1Panel.SetActive(true);
    }

    public void OnClickChangJingLu()
    {
        que1Panel.SetActive(false);
        que2Panel.SetActive(true);
    }

    public void OnClickGeZi()
    {
        que2Panel.SetActive(false);
        endRightPanel.SetActive(true);
    }

    public void OnClickPaoKuai()
    {
        que2Panel.SetActive(false);
        wrong2Panel.SetActive(true);
    }

    public void OnClickWrong2Back()
    {
        wrong2Panel.SetActive(false);
        que2Panel.SetActive(true);
    }

    public void OnClickEndRight()
    {
        endRightPanel.SetActive(false);
    }
}
