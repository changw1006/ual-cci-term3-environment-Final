using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelTouch : MonoBehaviour
{

    //开始位置
    Vector3 startPostion;
    //鼠标按下的之前位置
    Vector3 previousPosition;
    //鼠标按下之后的滑动距离
    Vector3 offset;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))    // Input.GetMouseButtonDown(0) 当0键被按下一次
        {
            startPostion = Input.mousePosition;
            previousPosition = Input.mousePosition;
        }
        if (Input.GetMouseButton(0))       // Input.GetMouseButton(0) 当0键被按住持续侦测(包含down和up各一次)
        {
            offset = Input.mousePosition - previousPosition;
            previousPosition = Input.mousePosition;
            transform.Rotate(Vector3.up, offset.magnitude, Space.World);
        }
    }
}
