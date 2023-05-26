using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDisplay : MonoBehaviour
{
    public Color boxEdgeColor = new Color(0, 0, 0, 0);
    public Color boxFaceColor = new Color(0, 0, 0, 0);
    
    [SerializeField] bool drawTriggerBox = true;
    private void OnDrawGizmos()
    {
        if(drawTriggerBox)
        {
            GetComponent<BoxCollider>().isTrigger = true;
            Vector3 drawBoxVector = new Vector3
                (
                this.transform.lossyScale.x * this.GetComponent<BoxCollider>().size.x,
                this.transform.lossyScale.y * this.GetComponent<BoxCollider>().size.y,
                this.transform.lossyScale.z * this.GetComponent<BoxCollider>().size.z
                );

            Vector3 drawBoxPosition = this.transform.position + this.GetComponent<BoxCollider>().center;

            Gizmos.matrix = Matrix4x4.TRS(drawBoxPosition, this.transform.rotation, drawBoxVector);
            Gizmos.color = boxFaceColor;
            Gizmos.DrawCube(Vector3.zero, Vector3.one);
            Gizmos.color = boxEdgeColor;
            Gizmos.DrawWireCube(Vector3.zero, Vector3.one);
        }
    }
}
