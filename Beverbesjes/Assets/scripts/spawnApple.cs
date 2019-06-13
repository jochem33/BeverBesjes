using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnApple : MonoBehaviour
{

    public GameObject apple;
    public Transform trans;

    public float fireRate = .1f;
    private float nextFire = 0.0f;
    
    void Update()
    {
        if (Time.time > nextFire)
        {
            Instantiate(apple, trans.position, Quaternion.identity);
            nextFire = Time.time + fireRate;
        }
        
    }
}
