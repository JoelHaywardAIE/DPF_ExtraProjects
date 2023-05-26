using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MonoBehaviour
{
    [Header ("Tank Parameters")]
    public float forwardSpeed = 0.1f;
    public float backwardSpeed = 0.08f;
    public float rotationSpeed = 2f;
    public int health = 100;

    [Header("Turret Parameters")]
    public float turretRotationSpeed = 3f;
    public GameObject turret;

    [Header("Shell Parameters")]
    public float shellSpeed = 20f;
    public GameObject shellPrefab;
    public Transform shellSpawnPoint;
    public int damageToTake = 2;

    [Header("Controls")]
    public KeyCode forwardsKey = KeyCode.W;
    public KeyCode backwardsKey = KeyCode.S;
    public KeyCode rotateLeftKey = KeyCode.A;
    public KeyCode rotateRightKey = KeyCode.D;
    public KeyCode rotateTurretLeftKey = KeyCode.Q;
    public KeyCode rotateTurretRightKey = KeyCode.E;
    public KeyCode shootKey = KeyCode.Space;

    public void TakeDamage(int damageToTake)
    {
        health -= damageToTake;
    }
    
    private void Update()
    {
        if(health <= 0)
        {
            Destroy(this.gameObject);
        }
        
        if (Input.GetKeyDown(shootKey))
        {
            GameObject GO = Instantiate(shellPrefab, shellSpawnPoint.position, Quaternion.identity) as GameObject;
            GO.GetComponent<Rigidbody>().velocity = turret.transform.forward * shellSpeed;
        }
    }
    // Update is called once per frame
    private void FixedUpdate()
    {
        if(Input.GetKey(rotateTurretLeftKey))
        {
            turret.transform.Rotate(0, -turretRotationSpeed, 0, Space.Self);
        }

        if(Input.GetKey(rotateTurretRightKey))
        {
            turret.transform.Rotate(0, turretRotationSpeed, 0, Space.Self);
        }
        
        if (Input.GetKey(forwardsKey))
        {
            transform.position = transform.position + transform.forward * forwardSpeed;
        }

        if (Input.GetKey(backwardsKey))
        {
            transform.position = transform.position + transform.forward * -backwardSpeed;
        }

        if (Input.GetKey(rotateLeftKey))
        {
            transform.Rotate(transform.up * -rotationSpeed);
        }

        if (Input.GetKey(rotateRightKey))
        {
            transform.Rotate(transform.up * rotationSpeed);
        }
    }
}
