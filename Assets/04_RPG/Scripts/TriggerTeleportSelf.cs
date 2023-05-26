using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTeleportSelf : MonoBehaviour
{
    public Transform teleportToTransform;
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            if(!teleportToTransform)
            {
                Debug.LogWarning("You have not assigned a reference for this teleport script");
            }

            other.transform.position = teleportToTransform.position;
            other.transform.rotation = teleportToTransform.rotation;
        }
    }

    private void OnDrawGizmosSelected()
    {
        if(teleportToTransform)
        {
            Debug.DrawLine(transform.position, teleportToTransform.position);
        }
    }
}
