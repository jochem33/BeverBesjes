using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public Camera cam;
    public Inventory inv;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
                if (hit.transform.tag == "pickable")
                {
                    if (inv.AddItemToInventory(inv.KeyByValue(hit.transform.name)))
                    {
                        inv.ChangeUIText();
                        Destroy(hit.transform.gameObject);
                    }
                    
                }
                else
                    print("I'm looking at nothing!");
        }
    }
}
