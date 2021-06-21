using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCtrl : MonoBehaviour {

    public void OnMouseDown()
    {
        Debug.Log(this.gameObject.name);
        TipsCtrl.instance.ShowTips(this.gameObject.name);
    }
}
