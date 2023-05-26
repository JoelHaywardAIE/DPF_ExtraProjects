using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipMover : MonoBehaviour
{
    public float upwardsThrust = 40f;
    public float forwardThrust = 20f;
    public float rotationalThrust = 5f;
    private Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(transform.up * upwardsThrust);
        }

        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.forward * forwardThrust);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(transform.forward * -forwardThrust);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddTorque(transform.forward * -rotationalThrust);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddTorque(transform.forward * rotationalThrust);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            rb.AddTorque(transform.up * -rotationalThrust);
        }

        if (Input.GetKey(KeyCode.E))
        {
            rb.AddTorque(transform.up * rotationalThrust);
        }
    }
}
