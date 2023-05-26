using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportObject : MonoBehaviour
{
    public GameObject objectToTeleport;
    public Transform teleportToTransform;
    public float teleportDelay = 1f;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Invoke("TeleportThisObject", teleportDelay);
        }
    }

    private void TeleportThisObject()
    {
        if(!teleportToTransform || !objectToTeleport)
        {
            Debug.LogWarning("You have not assigned a reference for this teleport script");
        }

        objectToTeleport.transform.position = teleportToTransform.position;
        objectToTeleport.transform.rotation = teleportToTransform.rotation;
    }

    private void OnDrawGizmosSelected()
    {
        if(teleportToTransform && objectToTeleport)
        {
            Debug.DrawLine(teleportToTransform.position, objectToTeleport.transform.position);
        }
    }
}
