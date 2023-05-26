using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventoryManager : MonoBehaviour
{
    public List<string> inventoryList = new List<string>();

    public GameObject inventoryPanel;
    public TMP_Text inventoryText;

    public void AddItem(string itemName)
    {
        inventoryList.Add(itemName);
        UpdateInventory();
    }

    public bool CheckItem(string itemName)
    {
        if(itemName == "")
        {
            return true;
        }
        return inventoryList.Contains(itemName);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            UpdateInventory();
            inventoryPanel.SetActive(!inventoryPanel.activeSelf);
        }
    }

    public void UpdateInventory()
    {
        string inventoryString = "";

        foreach(string item in inventoryList)
        {
            inventoryString += item + " \n";
        }

        inventoryText.text = inventoryString;
    }
}
