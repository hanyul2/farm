using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour
{

    public float turnSpeed = 4.0f; // 마우스 회전 속도
    private float xRotate = 0.0f; // 내부 사용할 X축 회전량은 별도 정의 ( 카메라 위 아래 방향 )
    public float moveSpeed = 4.0f; // 이동 속도
    public float rotateSpeed = 500.0f;

    void Update()
    {
            float xRotateSize = -Input.GetAxis("Mouse Y") * turnSpeed;
            
            xRotate = Mathf.Clamp(xRotate + xRotateSize, -45, 80);


            transform.eulerAngles = new Vector3(xRotate, transform.eulerAngles.y, 0);
    }
}