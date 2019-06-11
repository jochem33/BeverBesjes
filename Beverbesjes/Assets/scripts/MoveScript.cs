using UnityEngine;

public class MoveScript : MonoBehaviour
{
    public Camera cam;
    public Rigidbody rb;
    public int speed;
    public int maxSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        //get inputs en convert to movement
        if (Input.GetKey("w"))
        {
            rb.AddForce(new Vector3(cam.transform.forward.x, 0, cam.transform.forward.z).normalized * speed * Time.deltaTime);
        }
        
        if (Input.GetKey("d"))
        {
            rb.AddForce(new Vector3(cam.transform.right.x, 0, cam.transform.right.z).normalized * speed * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(new Vector3(cam.transform.right.x, 0, cam.transform.right.z).normalized * -speed * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(new Vector3(cam.transform.forward.x, 0, cam.transform.forward.z).normalized * -speed * Time.deltaTime);
        }

        //if no key pressed stop moving
        if (!Input.anyKeyDown)
        {
            rb.velocity = new Vector3(0, rb.velocity.y, 0);
        }

        //enforce max speed
        if (rb.velocity.x > maxSpeed)
        {
            rb.velocity = new Vector3(maxSpeed, 0 ,0);
        }
        if (rb.velocity.x < -maxSpeed)
        {
            rb.velocity = new Vector3(-maxSpeed, 0, 0);
        }
        if (rb.velocity.z > maxSpeed)
        {
            rb.velocity = new Vector3(0, 0, maxSpeed);
        }
        if (rb.velocity.z < -maxSpeed)
        {
            rb.velocity = new Vector3(0, 0, -maxSpeed);
        }

    }
}
