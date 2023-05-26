using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerActivate : MonoBehaviour
{
    public GameObject objectToActivate;
    public float interactDelay = 0;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Invoke("ActivateObject", interactDelay);
        }
    }

    private void ActivateObject()
    {
        objectToActivate.SetActive(true);
    }
}
