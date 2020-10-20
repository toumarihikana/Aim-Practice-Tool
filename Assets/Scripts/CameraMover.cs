using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    //cameraのtransform
    private Transform _camTransform;

    //マウス操作の始点
    private Vector3 _startMousePos;

    //カメラ回転の始点情報
    private Vector3 _presentCamRotation;

    public float xSensitivity = 1;
    public float ySensitivity = 1;

    [SerializeField]
    private MenuVisible menuVisible;
    
    void Start()
    {
        _camTransform = this.gameObject.transform;

        _startMousePos = Input.mousePosition;
    }

    void Update()
    {
        if (!menuVisible.IsMenuVisible)
        {
            //カメラの回転 マウス
            CameraRotationMouseControl();
        }
    }

    //カメラの回転 マウス
    private void CameraRotationMouseControl()
    {
        float xMouse = Input.GetAxis("Mouse X");
        float yMouse = Input.GetAxis("Mouse Y");

        _presentCamRotation.x = _camTransform.transform.eulerAngles.x;
        _presentCamRotation.y = _camTransform.transform.eulerAngles.y;
        

        //回転開始角度 ＋ マウスの変化量
        float eulerX = _presentCamRotation.x + yMouse * ySensitivity * -1;
        float eulerY = _presentCamRotation.y + xMouse * xSensitivity;

        _camTransform.rotation = Quaternion.Euler(eulerX, eulerY, 0);
        
    }

}