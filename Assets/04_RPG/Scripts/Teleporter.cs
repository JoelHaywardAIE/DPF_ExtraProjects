using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public GameObject teleportNode;
    public bool drawGizmo = false;
    
    void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            Vector3 nodeLocation = teleportNode.transform.position;
            other.transform.position = nodeLocation;
            Quaternion nodeRotation = teleportNode.transform.rotation;
            other.transform.rotation = nodeRotation;
        }
    }

    private void OnDrawGizmos()
    {
        if(teleportNode && drawGizmo)
        {
            Gizmos.color = Color.blue;
            Gizmos.DrawLine(transform.position, teleportNode.transform.position);
        }

    }
}
