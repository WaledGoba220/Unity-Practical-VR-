using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    
    public float speed = 5f;
    public KeyCode up;

    public KeyCode left;
    public KeyCode right;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        bool pressedUp = Input.GetKey(this.up);

        bool pressedRight = Input.GetKey(this.right);
        bool pressedLeft = Input.GetKey(this.left);

        if (pressedUp)
        {
            rb.velocity = Vector3.forward * speed;
        }
        else if (pressedRight)
        {
            rb.velocity = Vector3.right * (speed - 5);
        }
        else if (pressedLeft)
        {
            rb.velocity = Vector3.left * (speed - 5);
        }

    }
}
