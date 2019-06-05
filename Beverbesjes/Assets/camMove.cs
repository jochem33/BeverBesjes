using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camMove : MonoBehaviour
{
    public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;
    CursorLockMode wantedMode = CursorLockMode.Locked;

    void SetCursorState()
    {
        Cursor.lockState = wantedMode;
    }

    void Start()
    {
        Cursor.visible = false;
    }

    void Update()
    {

        if (Input.GetKey("escape"))
        {
            wantedMode = CursorLockMode.None;
            Application.Quit();
        }

        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");

        pitch = Mathf.Clamp(pitch, -70.0f, 70.0f);
        

        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);

        SetCursorState();
    }
}
