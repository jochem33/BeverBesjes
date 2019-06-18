﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PickUp : MonoBehaviour
{
    public Image myImageComponent;
    public Sprite myFirstImage; //Drag your first sprite here in inspector.
    public Sprite mySecondImage; //Drag your second sprite here in inspector.




    public Camera cam;
    

    void Update()
    {
        Ray ray = cam.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 5))
        {
            if (hit.transform.tag == "pickable")
            {
                print("dit kan ik oppakken");
                SetImage2();
            }
            else
            {
                SetImage1();
            }
        }
        

        
    }



    void OnMouseOver()
    {
        print("dit is een debug");
    }


    public void SetImage1() //method to set our first image
    {
        myImageComponent.sprite = myFirstImage;
    }

    public void SetImage2()
    {
        myImageComponent.sprite = mySecondImage;
    }
}
