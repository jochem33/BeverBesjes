using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class ChangeCrosshair2 : MonoBehaviour
{
    public Image canvasImage;
    public Sprite crosshairInactive;
    public Sprite crosshairActive;


    public Camera cam;

    void Start()
    {
        //code
    }

    void Update()
    {
        Ray ray = cam.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 7))
        {
            if (hit.transform.tag == "pickable")
            {
                canvasImage.sprite = crosshairActive;
            }
            else
            {
                canvasImage.sprite = crosshairInactive;
            }
        }
        else
        {
            canvasImage.sprite = crosshairInactive;
        }

    }
}
