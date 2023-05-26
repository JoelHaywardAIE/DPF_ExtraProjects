using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCube : MonoBehaviour
{
    private void OnTriggerEnter()
    {
        Debug.Log("Happy to see you");
    }

    private void OnTriggerExit()
    {
        Debug.Log("Sorry to see you go");
    }

    private void OnTriggerStay()
    {
        Debug.Log("I wish you would leave");
    }
}
