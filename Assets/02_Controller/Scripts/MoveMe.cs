using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class MoveMe : MonoBehaviour
{
    public float torqueVertical = 1.0f;
    public float torqueHorizontal = 1.0f;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    private void FixedUpdate()
    {
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * torqueVertical, ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.forward * torqueHorizontal);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector3.forward * -torqueHorizontal);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right * torqueHorizontal);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.right * -torqueHorizontal);
        }
    }
}
