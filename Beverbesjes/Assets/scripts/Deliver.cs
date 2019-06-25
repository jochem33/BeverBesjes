using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Deliver : MonoBehaviour
{
    public Inventory inv;
    public RectTransform rt;
    public Text ScoreText;
    public int Score = 0;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "tent")
        {
            
            for (int i = 0; i < inv.inventory.Length; i++)
            {
                int scoreAdd = inv.InventoryScoreRefrance[inv.InventoryItemRefrance[inv.inventory[i]]];

                for (int j = 0; j < inv.inventoryCount[i]; i++)
                {
                    Score += scoreAdd;
                    rt.localScale += new Vector3(scoreAdd * .01f, 0, 0);
                    print(j);
                }
            }

            string scoreTempText = "Score: ";
            scoreTempText += (Score).ToString();
            ScoreText.text = scoreTempText;
            inv.ResetInventory();
        }
    }
}
