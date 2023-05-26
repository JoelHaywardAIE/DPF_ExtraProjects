using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtMessage : MonoBehaviour
{
    public float distanceToTrigger = 5f;
    public float timeToTrigger = 1f;
    [Range(0.01f, 0.2f)]
    public float accuracy = 0.05f;
    public bool activateOnce = true;
    private float timer;

    public string messageToDisplay = "you looked at me!";
    public float messageDuration = 2;

    public string requireItem = "";

    // Update is called once per frame
    void Update()
    {
        if(!GameObject.FindObjectOfType<InventoryManager>().CheckItem(requireItem))
        {
            return;
        }

        float distanceToPlayer = Vector3.Distance(Camera.main.transform.position, transform.position);

        if(distanceToPlayer > distanceToTrigger)
        {
            timer = 0;
            return;
        }

        Vector3 playerForward = Camera.main.transform.forward;
        Vector3 objectToPlayer = Vector3.Normalize(transform.position - Camera.main.transform.position);

        Debug.DrawRay(Camera.main.transform.position, playerForward * distanceToTrigger);
        Debug.DrawRay(Camera.main.transform.position, objectToPlayer * distanceToTrigger, Color.yellow);

        if(Vector3.Dot(playerForward, objectToPlayer) < 1 - accuracy)
        {
            timer = 0;
            return;
        }

        timer += Time.deltaTime;

        if(timer >= timeToTrigger)
        {
            GameObject.FindObjectOfType<UIController>().ShowMessage(messageToDisplay, messageDuration);
            timer = 0;

            if(activateOnce)
            {
                this.enabled = false;
            }
        }
    }
}
