using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private float speed = 1;
    public float vida = 1;
    public GameObject mycam;
    public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;

    void Start()
    {
        
    }

    void Update()
    {
        MovementKeys();
        CameraControl();
    }

    void MovementKeys()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3 (0.1f*speed,0,0));
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3 (0,0,0.1f*speed));
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3 (-0.1f*speed,0,0));
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3 (0,0,-0.1f*speed));
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 2;
        }
        
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 1;
        }
    }
    void CameraControl()
    {
        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(pitch,yaw,0.0f);
    }

}
