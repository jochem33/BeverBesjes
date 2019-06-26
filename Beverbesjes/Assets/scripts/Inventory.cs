using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{

    public Text[] CountTexts = new Text[7];
    public Image[] ItemImages = new Image[7];
    public Sprite[] Sprites = new Sprite[3];

    public Dictionary<int, string> InventoryItemRefrance = new Dictionary<int, string>();
    public Dictionary<string, int> InventoryScoreRefrance = new Dictionary<string, int>();

    public int stackSize = 64;

    public static int inventorySize = 7;

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
        for (int i = 0; i < inventory.Length; i++)
        {
            SetCountText(i);
            SetSlotImage(i, inventory[i]);
        }
        
    }

    public void LengthenInventory()
    {
        inventorySize++;
        Array.Resize(ref inventory, inventorySize);
        Array.Resize(ref inventoryCount, inventorySize);
    }

    public string GetItemNameFromItemRefrance(int i)
    {
        return InventoryItemRefrance[i];
    }

    public int KeyByValue(string val)
    {
        int key = 0;
        foreach (KeyValuePair<int, string> pair in InventoryItemRefrance)
        {
            string temp = pair.Value;
            if (pair.Value == val || (temp += "(Clone)") == val)
            {
                key = pair.Key;
                break;
            }
        }
        return key;
    }

    public void SetSlotImage(int i, int id)
    {
        ItemImages[i].sprite = Sprites[id];
    }
    public void SetCountText(int i)
    {
        CountTexts[i].text = (inventoryCount[i]).ToString();
    }

    public void ResetInventory()
    {
        for(int i = 0; i < inventory.Length; i++)
        {
            inventory[i] = 0;
            inventoryCount[i] = 0;
        }
        ChangeUIText();
        
    }


    private void Awake()
    {
        InventoryItemRefrance.Add(0, "None");
        InventoryScoreRefrance.Add("None", 0);
        InventoryItemRefrance.Add(1, "Apple");
        InventoryScoreRefrance.Add("Apple", 10);
        InventoryItemRefrance.Add(2, "Peer");
        InventoryScoreRefrance.Add("Peer", 20);
        InventoryItemRefrance.Add(3, "Vliegenzwam");
        InventoryScoreRefrance.Add("Vliegenzwam", -75);
        InventoryItemRefrance.Add(4, "GeleRidderzwam");
        InventoryScoreRefrance.Add("GeleRidderzwam", -25);
        InventoryItemRefrance.Add(5, "Voorjaarskuifzwam");
        InventoryScoreRefrance.Add("Voorjaarskuifzwam", -50);
        InventoryItemRefrance.Add(6, "Paddenstoel");
        InventoryScoreRefrance.Add("Paddenstoel", 5);
        InventoryItemRefrance.Add(7, "Besje");
        InventoryScoreRefrance.Add("Besje", 5);


        ChangeUIText();
    }
}
