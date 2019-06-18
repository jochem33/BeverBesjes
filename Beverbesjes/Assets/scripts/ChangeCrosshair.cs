using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class ChangeCrosshair : MonoBehaviour
{
    Image myImageComponent;
    public Sprite myFirstImage; //Drag your first sprite here in inspector.
    public Sprite mySecondImage; //Drag your second sprite here in inspector.


    public Camera cam;

    void Start() //Lets start by getting a reference to our image component.
    {
        myImageComponent = GetComponent<Image>(); //Our image component is the one attached to this gameObject.
        print("A");
    }

    void update()
    {
        Ray ray = cam.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
            if (hit.transform.tag == "pickable")
            {
                print("dit kan ik oppakken");
                SetImage2();
            }
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
