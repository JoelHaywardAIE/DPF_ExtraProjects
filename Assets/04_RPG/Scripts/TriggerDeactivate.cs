using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDeactivate : MonoBehaviour
{
    public GameObject objectToDeactivate;
    public float interactDelay = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Invoke("DeactivateObject", interactDelay);
        }
    }

    private void DeactivateObject()
    {
        objectToDeactivate.SetActive(false);
    }
}
