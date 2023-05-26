using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(TriggerDisplay))]
public class TriggerMessage : MonoBehaviour
{
    [SerializeField] string messageToShow = "Default Message";
    [SerializeField] float messageDuration = 3f;

    public string requiresItem = "";

    private void OnTriggerEnter(Collider other)
    {
        if(!GameObject.FindObjectOfType<InventoryManager>().CheckItem(requiresItem))
        {
            return;
        }
        
        if(other.tag == "Player")
        {
            GameObject.FindObjectOfType<UIController>().ShowMessage(messageToShow, messageDuration);
        }
    }
}
