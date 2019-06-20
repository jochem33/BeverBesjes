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
        //canvasImage = GetComponent<Image>();
        print("AB");
    }

    void Update()
    {
        print("dit kan ik niet oppakken");

        Ray ray = cam.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 7))
        {
            if (hit.transform.tag == "pickable")
            {
                print("dit kan ik oppakken");
                //SetImage2();
                //Debug.Log(hit.collider.gameObject.name);
                canvasImage.sprite = crosshairActive;
            }
            else
            {
                //SetImage1();
                print("dit kan ik niet oppakken");
                canvasImage.sprite = crosshairInactive;
            }
        }
        else
        {
            //SetImage1();
            print("dit kan ik niet oppakken");
            canvasImage.sprite = crosshairInactive;
        }

    }


    public void SetImage1() //method to set our first image
    {
        canvasImage.sprite = crosshairInactive;
    }

    public void SetImage2()
    {
        canvasImage.sprite = crosshairActive;
    }
}
