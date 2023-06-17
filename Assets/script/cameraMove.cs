using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour
{

    public float turnSpeed = 4.0f; // ���콺 ȸ�� �ӵ�
    private float xRotate = 0.0f; // ���� ����� X�� ȸ������ ���� ���� ( ī�޶� �� �Ʒ� ���� )
    public float moveSpeed = 4.0f; // �̵� �ӵ�
    public float rotateSpeed = 500.0f;

    void Update()
    {
            float xRotateSize = -Input.GetAxis("Mouse Y") * turnSpeed;
            
            xRotate = Mathf.Clamp(xRotate + xRotateSize, -45, 80);


            transform.eulerAngles = new Vector3(xRotate, transform.eulerAngles.y, 0);
    }
}