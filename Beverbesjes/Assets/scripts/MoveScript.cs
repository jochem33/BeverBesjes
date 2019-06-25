using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveScript : MonoBehaviour
{
    public AudioClip deathSound;
    AudioSource audioSource;
    public Camera cam;
    public Rigidbody rb;
    public RectTransform rt;
    public int speed;
    public int maxSpeed;
    public RectTransform deathScreen;
    public float deathSpeedForwards = -0.00125f;
    public float deathSpeedLeftRight = -0.000625f;
    public float deathSpeedBackwards = -0.0006f;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey("w"))
        {
            rb.AddForce(new Vector3(cam.transform.forward.x, 0, cam.transform.forward.z) * speed);
            if (rt.transform.localScale.x >= 0)
            {
                rt.localScale += new Vector3(deathSpeedForwards, 0, 0);
            }
            else
            {
                Destroy(rb);
                if (deathScreen.transform.localPosition.x > 0)
                {
                    deathScreen.localPosition = new Vector3(0, 0, 0);
                    audioSource.PlayOneShot(deathSound, 1.0f);
                }
            }
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(new Vector3(cam.transform.right.x, 0, cam.transform.right.z) * speed);
            if (rt.transform.localScale.x >= 0)
            {
                rt.localScale += new Vector3(deathSpeedLeftRight, 0, 0);
            }
            else
            {
                Destroy(rb);
                if (deathScreen.transform.localPosition.x > 0)
                {
                    deathScreen.localPosition = new Vector3(0, 0, 0);
                    audioSource.PlayOneShot(deathSound, 1.0f);
                }
            }
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(new Vector3(cam.transform.right.x, 0, cam.transform.right.z) * -speed);
            if (rt.transform.localScale.x >= 0)
            {
                rt.localScale += new Vector3(deathSpeedLeftRight, 0, 0);
            }
            else
            {
                Destroy(rb);
                if (deathScreen.transform.localPosition.x > 0)
                {
                    deathScreen.localPosition = new Vector3(0, 0, 0);
                    audioSource.PlayOneShot(deathSound, 1.0f);
                }
            }
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(new Vector3(cam.transform.forward.x, 0, cam.transform.forward.z) * -speed);
            if (rt.transform.localScale.x >= 0)
            {
                rt.localScale += new Vector3(deathSpeedBackwards, 0, 0);
            }
            else
            {
                Destroy(rb);
                if (deathScreen.transform.localPosition.x > 0)
                {
                    deathScreen.localPosition = new Vector3(0, 0, 0);
                    audioSource.PlayOneShot(deathSound, 1.0f);
                }
            }
        }

        if (!Input.anyKeyDown)
        {
            rb.velocity = new Vector3(0, rb.velocity.y, 0);
        }
        if (rb.velocity.x > maxSpeed)
        {
            rb.velocity = new Vector3(maxSpeed, 0, 0);
        }
        if (rb.velocity.z > maxSpeed)
        {
            rb.velocity = new Vector3(0, 0, maxSpeed);
        }

    }
}
