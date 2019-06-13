using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public Text invetoryText;

    public int stackSize = 64;

    public static int inventorySize = 5;

    public int[] inventory = new int[inventorySize];
    

    public int[] inventoryCount = new int[inventorySize];

    public bool AddItemToInventory(int item)
    {
        for (int i = 0; i < inventory.Length; i++)
        {
            int slot = inventory[i];

            if (slot == item && inventoryCount[i] < stackSize)
            {
                inventoryCount[i]++;
                return true;
            }
            else if (slot != item && inventoryCount[i] == 0)
            {
                inventory[i] = item;
                inventoryCount[i]++;
                return true;
            }
        }
        return false;
    }
    public void ChangeUIText()
    {
        invetoryText.text = "";
        for (int i = 0; i < inventory.Length; i++)
        {
            invetoryText.text += inventory[i];
            invetoryText.text += " : ";
            invetoryText.text += inventoryCount[i];
            invetoryText.text += "\n";
        }
        
    }

    public void LengthenInventory()
    {
        inventorySize++;
        Array.Resize(ref inventory, inventorySize);
        Array.Resize(ref inventoryCount, inventorySize);
    }

    private void Awake()
    {
        ChangeUIText();
    }
}
