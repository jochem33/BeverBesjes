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
            int scoreAdd = 0;

            for (int i = 0; i < inv.inventory.Length; i++)
            {
                scoreAdd += inv.InventoryScoreRefrance[inv.InventoryItemRefrance[inv.inventory[i]]] * inv.inventoryCount[i];
                print(scoreAdd);
            }

            rt.transform.localScale += new Vector3(scoreAdd*.001f, 0, 0);
            Score += scoreAdd;

            string scoreTempText = "Score: ";
            scoreTempText += (Score).ToString();
            ScoreText.text = scoreTempText;

            inv.ResetInventory();
        }
    }
}
