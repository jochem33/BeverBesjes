using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
    public void ExitTheGame() {
        Debug.Log("Hij is gequit!!!!!");
        Application.Quit();
    }
}
