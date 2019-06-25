using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemRb : MonoBehaviour
{
    public Rigidbody rb;
    public RemRb script;

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(rb);
        Destroy(script);
    }
}
