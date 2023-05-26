using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    [SerializeField] float speed = 20f;
    [SerializeField] float rollWeight = 2f;
    [SerializeField] float pitchWeight = 2f;
    [SerializeField] float thrust = 5f;
    [SerializeField] float maxThrust = 100f;
    [SerializeField] float drag = 5f;
    [SerializeField] float maxDrag = 1f;

    [SerializeField] Quaternion startingRotation;
    [SerializeField] Vector3 startingPosition;

    private void Start()
    {
        startingPosition = transform.position;
        startingRotation = transform.rotation;
    }

    void OnCollisionEnter()
    {
        ResetPlayer();
    }

    void Update()
    {
        if (transform.position.x <= -300 || transform.position.x >= 300)
        {
            ResetPlayer();
        }

        if (transform.position.y <= -50 || transform.position.y >= 300)
        {
            ResetPlayer();
        }
        
        if(transform.position.z <= -300 || transform.position.z >= 300)
        {
            ResetPlayer();
        }
        
        float roll = -rollWeight * Input.GetAxis("Horizontal");
        float pitch = pitchWeight * Input.GetAxis("Vertical");
        Vector3 shipRotation = new Vector3(pitch, 0, roll);

        transform.Rotate(shipRotation);

        if(Input.GetButton("Jump"))
        {
            speed += thrust;

            if(speed > maxThrust)
            {
                speed = maxThrust;
            }
        }
        else
        {
            speed -= drag;
            
            if (speed < maxDrag)
            {
                speed = 20;
            }
        }

        transform.position += transform.forward * speed * Time.deltaTime;
    }

    private void ResetPlayer()
    {
        this.transform.position = startingPosition;
        this.transform.rotation = startingRotation;
        GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        GetComponent<Rigidbody>().velocity = Vector3.zero;
    }
}
